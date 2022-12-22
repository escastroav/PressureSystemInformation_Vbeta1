using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

using PressureSystemInformation_Vbeta1.Report;
using PressureSystemInformation_Vbeta1.Test;
namespace PressureSystemInformation_Vbeta1
{
    public partial class ReportForm : Form
    {
        public ReportTest report;
        LeakTest test;
        public ReportForm(LeakTest test)
        {
            InitializeComponent();
            this.test = test;
        }        
        private void ReportForm_Load(object sender, EventArgs e)
        {
            report = new ReportTest
            (
                test,
                ReportDataControl.GetClientName(),
                ReportDataControl.GetClientID(),
                ReportDataControl.GetOperatorName(),
                ReportDataControl.GetOperatorObs(),
                ReportDataControl.GetDeviceName(),
                ReportDataControl.GetDeviceSerial(),
                ReportDataControl.GetTransducerSerial(),
                ReportDataControl.GetDeviceDescription(),
                ReportDataControl.GetDeviceExpireDate()
            );
            GenerateReport();
        }
        public void UpdateReport()
        {            
            report = new ReportTest
            (
                test,
                ReportDataControl.GetClientName(),
                ReportDataControl.GetClientID(),
                ReportDataControl.GetOperatorName(),
                ReportDataControl.GetOperatorObs(),
                ReportDataControl.GetDeviceName(),
                ReportDataControl.GetDeviceSerial(),
                ReportDataControl.GetTransducerSerial(),
                ReportDataControl.GetDeviceDescription(),
                ReportDataControl.GetDeviceExpireDate()
            );
            GenerateReport();
        }

        public void GenerateReport() 
        {
            List<ReportTest> reports = new List<ReportTest>();
            reports.Add(report);
            ReportDataSource repSource = new ReportDataSource("Report", reports);

            List<PressureAndTimeData> PT = test.PTDataRep;
            ReportDataSource repPTsource = new ReportDataSource("PressureAndTimeData", PT);

            List<LeakCycle> cycles = test.cyclesRep;
            ReportDataSource repCyclesSource = new ReportDataSource("LeakCycle", cycles);

            ReportViewer.LocalReport.ReportEmbeddedResource = "PressureSystemInformation_Vbeta1.Report.ReportDesign.rdlc";

            ReportViewer.LocalReport.DataSources.Clear();
            ReportViewer.LocalReport.DataSources.Add(repSource);
            ReportViewer.LocalReport.DataSources.Add(repPTsource);
            ReportViewer.LocalReport.DataSources.Add(repCyclesSource);

            ReportViewer.Invoke((MethodInvoker)(() => { ReportViewer.RefreshReport(); }));
        }
    }
}
