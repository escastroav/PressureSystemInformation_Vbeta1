
namespace PressureSystemInformation_Vbeta1.Controls
{
    partial class GraphControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.GraphGrid = new System.Windows.Forms.TableLayoutPanel();
            this.ExportGraphButton = new System.Windows.Forms.Button();
            this.PressureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EndCycleButton = new System.Windows.Forms.Button();
            this.StartCycleButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.GraphPanel.SuspendLayout();
            this.GraphGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PressureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphPanel
            // 
            this.GraphPanel.BackColor = System.Drawing.Color.DarkGray;
            this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GraphPanel.Controls.Add(this.GraphGrid);
            this.GraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphPanel.Margin = new System.Windows.Forms.Padding(5);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(803, 509);
            this.GraphPanel.TabIndex = 3;
            // 
            // GraphGrid
            // 
            this.GraphGrid.ColumnCount = 6;
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.GraphGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.GraphGrid.Controls.Add(this.ExportGraphButton, 5, 1);
            this.GraphGrid.Controls.Add(this.PressureChart, 0, 0);
            this.GraphGrid.Controls.Add(this.EndCycleButton, 3, 1);
            this.GraphGrid.Controls.Add(this.StartCycleButton, 2, 1);
            this.GraphGrid.Controls.Add(this.StopButton, 4, 1);
            this.GraphGrid.Controls.Add(this.StartButton, 1, 1);
            this.GraphGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphGrid.Location = new System.Drawing.Point(0, 0);
            this.GraphGrid.Margin = new System.Windows.Forms.Padding(0);
            this.GraphGrid.Name = "GraphGrid";
            this.GraphGrid.RowCount = 2;
            this.GraphGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.GraphGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.GraphGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GraphGrid.Size = new System.Drawing.Size(799, 505);
            this.GraphGrid.TabIndex = 1;
            // 
            // ExportGraphButton
            // 
            this.ExportGraphButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExportGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportGraphButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportGraphButton.Location = new System.Drawing.Point(696, 464);
            this.ExportGraphButton.Margin = new System.Windows.Forms.Padding(45, 10, 10, 10);
            this.ExportGraphButton.Name = "ExportGraphButton";
            this.ExportGraphButton.Size = new System.Drawing.Size(93, 31);
            this.ExportGraphButton.TabIndex = 4;
            this.ExportGraphButton.Text = "EXPORTAR";
            this.ExportGraphButton.UseVisualStyleBackColor = false;
            this.ExportGraphButton.Click += new System.EventHandler(this.ExportGraphButton_Click);
            // 
            // PressureChart
            // 
            this.PressureChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.InterlacedColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Title = "TIEMPO [SEC]";
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisY.LineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisY.Title = "PRESION [PSI]";
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            chartArea1.Name = "PressureTime";
            this.PressureChart.ChartAreas.Add(chartArea1);
            this.GraphGrid.SetColumnSpan(this.PressureChart, 6);
            this.PressureChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PressureChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressureChart.Location = new System.Drawing.Point(3, 3);
            this.PressureChart.Name = "PressureChart";
            this.PressureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.PressureChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Cyan,
        System.Drawing.SystemColors.HighlightText,
        System.Drawing.Color.Red};
            series1.ChartArea = "PressureTime";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "IsXAxisQuantitative=True";
            series1.LabelForeColor = System.Drawing.SystemColors.Control;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "PCurve";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.PressureChart.Series.Add(series1);
            this.PressureChart.Size = new System.Drawing.Size(793, 448);
            this.PressureChart.TabIndex = 0;
            this.PressureChart.Text = "Pressure Chart";
            title1.BorderWidth = 3;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.SystemColors.Control;
            title1.Name = "PressureTitle";
            title1.Text = "GRÁFICO DE PRESIÓN VS. TIEMPO";
            this.PressureChart.Titles.Add(title1);
            // 
            // EndCycleButton
            // 
            this.EndCycleButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EndCycleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndCycleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndCycleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EndCycleButton.Location = new System.Drawing.Point(400, 457);
            this.EndCycleButton.Name = "EndCycleButton";
            this.EndCycleButton.Size = new System.Drawing.Size(121, 45);
            this.EndCycleButton.TabIndex = 3;
            this.EndCycleButton.Text = "TERMINAR CICLO";
            this.EndCycleButton.UseVisualStyleBackColor = false;
            this.EndCycleButton.Click += new System.EventHandler(this.EndCycleButton_Click);
            // 
            // StartCycleButton
            // 
            this.StartCycleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartCycleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartCycleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StartCycleButton.Location = new System.Drawing.Point(273, 457);
            this.StartCycleButton.Name = "StartCycleButton";
            this.StartCycleButton.Size = new System.Drawing.Size(121, 45);
            this.StartCycleButton.TabIndex = 2;
            this.StartCycleButton.Text = "INICIAR CICLO";
            this.StartCycleButton.UseVisualStyleBackColor = false;
            this.StartCycleButton.Click += new System.EventHandler(this.StartCycleButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Maroon;
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StopButton.Location = new System.Drawing.Point(527, 457);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(121, 45);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "DETENER";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkGreen;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StartButton.Location = new System.Drawing.Point(146, 457);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(121, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "COMENZAR";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GraphPanel);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(803, 509);
            this.GraphPanel.ResumeLayout(false);
            this.GraphGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PressureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.TableLayoutPanel GraphGrid;
        private System.Windows.Forms.Button ExportGraphButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart PressureChart;
        private System.Windows.Forms.Button EndCycleButton;
        private System.Windows.Forms.Button StartCycleButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
    }
}
