using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressureSystemInformation_Vbeta1.Controls.Report
{
    public partial class ReportData : UserControl
    {
        public ReportData()
        {
            InitializeComponent();
        }

        public string GetClientName() => ClientNameTextBox.Text;
        public string GetClientID() => ClientIDTextBox.Text;
        public string GetOperatorName() => OperatorNameTextBox.Text;
        public string GetOperatorObs() => ObservationsTextBox.Text;
        public string GetDeviceName() => DeviceNameTextBox.Text;
        public string GetDeviceSerial() => SerialTextBox.Text;
        public string GetTransducerSerial() => TransducerSerialTextBox.Text;
        public string GetDeviceDescription() => DescriptionTextBox.Text;
        public DateTime GetDeviceExpireDate() => ExpireDateTimePicker.Value;
        private void ReportData_Load(object sender, EventArgs e)
        {
            ExpireDateTimePicker.Value.AddYears(1);
        }

        private void UpdateReportButton_Click(object sender, EventArgs e)
        {
            ReportForm form = ParentForm as ReportForm;
            form.UpdateReport();
        }
    }
}
