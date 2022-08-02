using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using PressureSystemInformation_Vbeta1.SerialCommunication;

namespace PressureSystemInformation_Vbeta1.Controls
{
    public partial class COMControl : UserControl, IStateHandlerControl
    {        
        public COMControl()
        {
            InitializeComponent();
        }
        public void DisableControl()
        {
            COMComboBox.Enabled = false;
            SampleTimeTextBox.Enabled = false;
        }
        public void EnableControl()
        {
            COMComboBox.Enabled = true;
            SampleTimeTextBox.Enabled = true;
        }
        public string GetPortName() => COMComboBox.Text;
        public int GetSampleTime() => Convert.ToInt32(SampleTimeTextBox.Text);
        public void SetupSerialCom(SerialCommunicationProtocol serialCom) 
        {
            serialCom.SetPortNamesTo(COMComboBox);
        }
    }
}
