using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using PressureSystemInformation_Vbeta1.SerialCommunication;
namespace PressureSystemInformation_Vbeta1.Controls
{
    public partial class SettingsControl : UserControl, IStateHandlerControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }
        public ComboBox GetCOMCB() => COMComboBox;
        public void DisableControl()
        {
            COMComboBox.Enabled = false;
            ExpectationModeComboBox.Enabled = false;
            SampleTimeTextBox.Enabled = false;
            ExpectedPercentTextBox.Enabled = false;

            MaxPressTextBox.Enabled = false;
            MinPressTextBox.Enabled = false;
            MaxVoltTextBox.Enabled = false;
            MinVoltTextBox.Enabled = false;
            CleanControlButton.Enabled = false;
            reportButton.Enabled = false;
        }
        public void EnableControl()
        {
            COMComboBox.Enabled = true; 
            if(COMComboBox.Items.Count > 0)
                COMComboBox.SelectedItem = COMComboBox.Items[0];
            ExpectationModeComboBox.Enabled = true; ExpectationModeComboBox.SelectedItem = ExpectationModeComboBox.Items[0];
            GraphStyleComboBox.Enabled = true; GraphStyleComboBox.SelectedItem = GraphStyleComboBox.Items[0];
            SampleTimeTextBox.Enabled = true;
            ExpectedPercentTextBox.Enabled = true;

            MaxPressTextBox.Enabled = true;
            MinPressTextBox.Enabled = true;
            MaxVoltTextBox.Enabled = true;
            MinVoltTextBox.Enabled = true;
            CleanControlButton.Enabled = true;
            reportButton.Enabled = true;
        }
        public bool CheckAllFields() 
        {
            bool isFull = !string.IsNullOrEmpty(COMComboBox.Text) &&
                          !string.IsNullOrEmpty(SampleTimeTextBox.Text) &&
                          !string.IsNullOrEmpty(ExpectedPercentTextBox.Text) &&
                          !string.IsNullOrEmpty(MaxPressTextBox.Text) &&
                          !string.IsNullOrEmpty(MinPressTextBox.Text) &&
                          !string.IsNullOrEmpty(MaxVoltTextBox.Text) &&
                          !string.IsNullOrEmpty(MinVoltTextBox.Text);
            return isFull;
        }
        
        public string GetPortName() => COMComboBox.Text;
        public int GetSampleTime() => Convert.ToInt32(SampleTimeTextBox.Text, CultureInfo.InvariantCulture);
        public double GetMaxP() => Convert.ToDouble(MaxPressTextBox.Text, CultureInfo.InvariantCulture);
        public double GetMinP() => Convert.ToDouble(MinPressTextBox.Text, CultureInfo.InvariantCulture);
        public double GetMaxV() => Convert.ToDouble(MaxVoltTextBox.Text, CultureInfo.InvariantCulture);
        public double GetMinV() => Convert.ToDouble(MinVoltTextBox.Text, CultureInfo.InvariantCulture);
        public double GetExpDrop() => Convert.ToDouble(ExpectedPercentTextBox.Text, CultureInfo.InvariantCulture);
        public string GetExpType() => ExpectationModeComboBox.Text;
        public void SetupSerialCom(SerialCommunicationProtocol serialCom)
        {
            serialCom.SetPortNamesTo(COMComboBox);
        }

        private void CleanControlButton_Click(object sender, EventArgs e)
        {
            SampleTimeTextBox.Clear();
            ExpectedPercentTextBox.Clear();

            MaxPressTextBox.Clear();
            MinPressTextBox.Clear();
            MaxVoltTextBox.Clear();
            MinVoltTextBox.Clear();
        }

        private void NoLettersAllowed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ChangeGraphStyle(object sender, EventArgs e)
        {
            MainForm form = ParentForm as MainForm;
            form.SetStyleForGraph(GraphStyleComboBox.Text);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MainForm form = ParentForm as MainForm;
            form.OpenReportEditor();
        }
    }
}
