using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace PressureSystemInformation_Vbeta1.SerialCommunication
{
    public class SerialCommunicationProtocol
    {
        private SerialPort mainSerialPort;
        private string[] serialPortsNames;

        public SerialCommunicationProtocol(SerialPort mainSerialPort)
        {
            this.mainSerialPort = mainSerialPort;            
            serialPortsNames = SerialPort.GetPortNames();
        }

        public void SetPortNamesTo(ComboBox comboBox) 
        {
            comboBox.Items.AddRange(serialPortsNames);
        }

        public bool InitializeSerialCommunication(string SelectedComPort, int sampleTime) 
        {
            try
            {
                mainSerialPort.PortName = SelectedComPort;
                mainSerialPort.BaudRate = 9600;
                mainSerialPort.Open();

                SetSampleTime(sampleTime);
                //mainSerialPort.WriteLine("$On");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void StartToRegister() 
        {
            try
            {
                mainSerialPort.WriteLine("$On");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        
        }

        public void EndSerialCommunication() 
        {
            try
            {
                mainSerialPort.WriteLine("$Off");
                mainSerialPort.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetSampleTime(int sampleTime)
        {
            if(mainSerialPort.IsOpen) 
                mainSerialPort.WriteLine("S" + Convert.ToString(sampleTime));
        }

        public bool CanReadData() 
        {
            return (mainSerialPort.IsOpen && mainSerialPort.BytesToRead > 0);
        }

        public int ReadData() 
        {
            string serialData = mainSerialPort.ReadLine();            
            return Convert.ToInt32(serialData);
        }

    }
}
