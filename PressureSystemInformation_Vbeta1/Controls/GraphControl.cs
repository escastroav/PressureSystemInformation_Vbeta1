using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.IO.Ports;
using fm = System.Web.UI.DataVisualization.Charting;


using PressureSystemInformation_Vbeta1.Visualization;
using PressureSystemInformation_Vbeta1.SerialCommunication;
using PressureSystemInformation_Vbeta1.Test;

namespace PressureSystemInformation_Vbeta1.Controls
{
    public partial class GraphControl : UserControl, IStateHandlerControl
    {       
        private PressureGraph pressureGraph;       
        public GraphControl()
        {
            InitializeComponent();
            pressureGraph = new PressureGraph(PressureChart);
        }
        public int GetCount() => pressureGraph.GetPointCount();
        public void DisableControl()
        {
            StartCycleButton.Enabled = false;
            StopButton.Enabled = true;
            StartCycleButton.Enabled = true;
            EndCycleButton.Enabled = false;

            ExportGraphButton.Enabled = false;
        }
        public void EnableControl()
        {
            StartCycleButton.Enabled = true;
            StopButton.Enabled = false;
            StartCycleButton.Enabled = false;
            EndCycleButton.Enabled = false;

            ExportGraphButton.Enabled = true;
        }
        public void RegisterState() 
        {
            StartCycleButton.Enabled = false;
            StopButton.Enabled = false;
            StartCycleButton.Enabled = false;
            EndCycleButton.Enabled = true;

            ExportGraphButton.Enabled = false;
        }
        public void ChangeStyle(string style) 
        {
            pressureGraph.SetStyleTo(style);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {            
            MainForm form = this.ParentForm as MainForm;
            if (form.BeginTest()) 
            {
                pressureGraph.Clean();
                DisableControl();
            }
            
        }
        private void StartCycleButton_Click(object sender, EventArgs e)
        {
            MainForm form = this.ParentForm as MainForm;
            form.BeginCycle();
            RegisterState();
            pressureGraph.AddStartLine(pressureGraph.GetLastMeasurement().XValue);
        }
        private void EndCycleButton_Click(object sender, EventArgs e)
        {
            MainForm form = this.ParentForm as MainForm;
            form.EndCycle();
            DisableControl();
            pressureGraph.AddEndLine(pressureGraph.GetLastMeasurement().XValue);
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            MainForm form = this.ParentForm as MainForm;
            form.EndTest();
            EnableControl();
        }       
        public void UpdateGraph(double timeCounter, double input) 
        {
            pressureGraph.AddPoint(timeCounter, input);
        }

        private void ExportGraphButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            save.Title = "Guardar Gráfico";
            save.ShowDialog();

            if (save.FileName != "") 
            {

                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        pressureGraph.SaveChart(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pressureGraph.SaveChart(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pressureGraph.SaveChart(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;

                    case 4:
                        pressureGraph.SaveChart(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }
    }
}
