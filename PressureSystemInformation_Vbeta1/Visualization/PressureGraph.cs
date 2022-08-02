using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PressureSystemInformation_Vbeta1.Visualization
{
    public class PressureGraph
    {
        private Chart pressureChart;
        private DataPointCollection points;

        private List<VerticalLineAnnotation> cycleStartLines;
        private List<VerticalLineAnnotation> cycleEndLines;
        public PressureGraph(Chart chart) 
        {
            pressureChart = chart;
            points = chart.Series[0].Points;
            points.Clear();
            cycleStartLines = new List<VerticalLineAnnotation>();
            cycleEndLines = new List<VerticalLineAnnotation>();
        }

        public void AddPoint(double Xvalue, double Yvalue) 
        {
            pressureChart.Invoke
                ((MethodInvoker)
                    (() =>
                        pressureChart.Series[0].Points.AddXY(Xvalue, Yvalue)
                    ));
        }

        public int GetPointCount() 
        {
            return points.Count;
        }

        public DataPoint GetLastMeasurement() 
        {
            return points.Last();
        }
       
        public void Clean() 
        {
            pressureChart.Invoke
                ((MethodInvoker)
                    (() =>
                        pressureChart.Series[0].Points.Clear()
                    ));
            pressureChart.Invoke
                ((MethodInvoker)
                    (() =>
                        pressureChart.Annotations.Clear()
                    ));
            cycleStartLines.Clear();
            cycleEndLines.Clear();
        }
        public void SaveChart(System.IO.FileStream fs, System.Drawing.Imaging.ImageFormat format) 
        {
            pressureChart.SaveImage(fs, format);
        }
        public void SetStyleTo(string style) 
        {
            switch (style) 
            {
                case "Light":
                    SetLightStyle();
                    break;
                case "Dark":
                    SetDartkStyle();
                    break;
            }
        }
        private void SetLightStyle()
        {
            pressureChart.BackColor = Color.White;
            pressureChart.Titles[0].ForeColor = Color.Black;
            pressureChart.ChartAreas[0].BackColor = Color.White;
            pressureChart.ChartAreas[0].AxisX.LineColor = Color.Black;
            pressureChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.DarkGray;
            pressureChart.ChartAreas[0].AxisX.TitleForeColor = Color.Black;
            pressureChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            pressureChart.ChartAreas[0].AxisY.LineColor = Color.Black;
            pressureChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.DarkGray;
            pressureChart.ChartAreas[0].AxisY.TitleForeColor = Color.Black;
            pressureChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;
            pressureChart.Series[0].Color = Color.DarkBlue;
        }
        private void SetDartkStyle() 
        {
            pressureChart.BackColor = Color.FromArgb(255, 16, 32, 64);
            pressureChart.Titles[0].ForeColor = Color.WhiteSmoke;
            pressureChart.ChartAreas[0].BackColor = Color.FromArgb(255, 16, 32, 64);
            pressureChart.ChartAreas[0].AxisX.LineColor = Color.WhiteSmoke;
            pressureChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            pressureChart.ChartAreas[0].AxisX.TitleForeColor = Color.WhiteSmoke;
            pressureChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            pressureChart.ChartAreas[0].AxisY.LineColor = Color.WhiteSmoke;
            pressureChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            pressureChart.ChartAreas[0].AxisY.TitleForeColor = Color.WhiteSmoke;
            pressureChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            pressureChart.Series[0].Color = Color.Red;
        }
        public void AddStartLine(double Xpoint) 
        {
            cycleStartLines.Add(new VerticalLineAnnotation());
            SetLine(cycleStartLines.Last(), Color.Yellow, Xpoint);
        }

        public void AddEndLine(double Xpoint)
        {
            cycleEndLines.Add(new VerticalLineAnnotation());
            SetLine(cycleEndLines.Last(), Color.Green, Xpoint);
        }

        public void SetLine(VerticalLineAnnotation line, Color col, double x) 
        {
            line.AxisX = pressureChart.ChartAreas[0].AxisX;
            line.ClipToChartArea = pressureChart.ChartAreas[0].Name;
            line.AllowMoving = false;
            line.IsInfinitive = true;
            line.LineColor = col;
            line.Width = 2;
            line.X = x;

            pressureChart.Annotations.Add(line);
        }
    }
}
