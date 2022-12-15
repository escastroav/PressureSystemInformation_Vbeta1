using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO.Ports;

using PressureSystemInformation_Vbeta1.Test;
using PressureSystemInformation_Vbeta1.SerialCommunication;
using PressureSystemInformation_Vbeta1.Visualization;
using PressureSystemInformation_Vbeta1.Controls;

namespace PressureSystemInformation_Vbeta1
{
    public partial class MainForm : Form
    {                        
        private SerialCommunicationProtocol MainSerialCom;                
        private LeakTest test;
        public MainForm()
        {            
            InitializeComponent();
            MainSerialCom = new SerialCommunicationProtocol(MainSerialPort);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            settingsControl.SetupSerialCom(MainSerialCom);
            graphControl.EnableControl();
            settingsControl.EnableControl();           
        }

        public void SetStyleForGraph(string style) 
        {
            graphControl.ChangeStyle(style);
        }
        public bool BeginTest() 
        {
            string portName = "";
            int sampleTime = 0;
            bool initializationDone = false;
            
            if (settingsControl.CheckAllFields())
            { 
                portName = settingsControl.GetPortName();
                sampleTime = settingsControl.GetSampleTime();
                initializationDone = MainSerialCom.InitializeSerialCommunication(portName, sampleTime);

                if (portName != "" && sampleTime > 0 && initializationDone)
                {
                    try
                    {
                        test = new LeakTest(
                        DateTime.Now,
                        settingsControl.GetSampleTime(),
                        registerCycleControl.GetCycleList(),
                        settingsControl.GetMaxP(),
                        settingsControl.GetMinP(),
                        settingsControl.GetMaxV(),
                        settingsControl.GetMinV());
                        settingsControl.DisableControl();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    MainSerialCom.StartToRegister();
                    return true;
                }
                else
                    MessageBox.Show("Por favor ingrese datos validos o conecte el dispositivo correcto.");

            }
            else
                MessageBox.Show("Por favor diligencie todos los campos antes de comenzar.");
            return false;
        }       

        public void EndTest() 
        {
            settingsControl.EnableControl();
            MainSerialCom.EndSerialCommunication();
        }

        public void BeginCycle() 
        {            
            test.StartNewCycle();         
        }

        public void EndCycle() 
        {
            test.StopLastCycle(settingsControl.GetExpDrop(),settingsControl.GetExpType());
        }

        private void MainSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int input;
            int timeCounter = 0;
            while (MainSerialCom.CanReadData()) 
            {
                input = MainSerialCom.ReadData();
                timeCounter = graphControl.GetCount();

                test.AddPTData(timeCounter, input);

                if(test.IsRegisteringCycle)
                    test.UpdateCycle();

                test.RenderData(graphControl, monitorControl);          
            }
        }       
    }
}
