
namespace PressureSystemInformation_Vbeta1
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.WindowGrid = new System.Windows.Forms.TableLayoutPanel();
            this.registerContainer = new System.Windows.Forms.Panel();
            this.RegisterGrid = new System.Windows.Forms.TableLayoutPanel();
            this.monitorControl = new PressureSystemInformation_Vbeta1.Controls.MonitorControl();
            this.registerCycleControl = new PressureSystemInformation_Vbeta1.Controls.RegisterCycleControl();
            this.graphControl = new PressureSystemInformation_Vbeta1.Controls.GraphControl();
            this.settingsControl = new PressureSystemInformation_Vbeta1.Controls.SettingsControl();
            this.brand = new PressureSystemInformation_Vbeta1.Controls.BrandControl();
            this.WindowGrid.SuspendLayout();
            this.registerContainer.SuspendLayout();
            this.RegisterGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSerialPort
            // 
            this.MainSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MainSerialPort_DataReceived);
            // 
            // WindowGrid
            // 
            this.WindowGrid.ColumnCount = 1;
            this.WindowGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowGrid.Controls.Add(this.registerContainer, 0, 0);
            this.WindowGrid.Controls.Add(this.brand, 0, 1);
            this.WindowGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowGrid.Location = new System.Drawing.Point(0, 0);
            this.WindowGrid.Margin = new System.Windows.Forms.Padding(0);
            this.WindowGrid.Name = "WindowGrid";
            this.WindowGrid.RowCount = 2;
            this.WindowGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.WindowGrid.Size = new System.Drawing.Size(948, 611);
            this.WindowGrid.TabIndex = 1;
            // 
            // registerContainer
            // 
            this.registerContainer.BackColor = System.Drawing.Color.Gray;
            this.registerContainer.Controls.Add(this.RegisterGrid);
            this.registerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerContainer.Location = new System.Drawing.Point(0, 0);
            this.registerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.registerContainer.Name = "registerContainer";
            this.registerContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.registerContainer.Size = new System.Drawing.Size(948, 583);
            this.registerContainer.TabIndex = 1;
            // 
            // RegisterGrid
            // 
            this.RegisterGrid.ColumnCount = 2;
            this.RegisterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87152F));
            this.RegisterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.12848F));
            this.RegisterGrid.Controls.Add(this.monitorControl, 0, 0);
            this.RegisterGrid.Controls.Add(this.registerCycleControl, 1, 2);
            this.RegisterGrid.Controls.Add(this.graphControl, 1, 0);
            this.RegisterGrid.Controls.Add(this.settingsControl, 0, 1);
            this.RegisterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterGrid.Location = new System.Drawing.Point(0, 0);
            this.RegisterGrid.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterGrid.Name = "RegisterGrid";
            this.RegisterGrid.RowCount = 3;
            this.RegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.54231F));
            this.RegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.3057F));
            this.RegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.3247F));
            this.RegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegisterGrid.Size = new System.Drawing.Size(948, 578);
            this.RegisterGrid.TabIndex = 0;
            // 
            // monitorControl
            // 
            this.monitorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorControl.Location = new System.Drawing.Point(5, 5);
            this.monitorControl.Margin = new System.Windows.Forms.Padding(5);
            this.monitorControl.Name = "monitorControl";
            this.monitorControl.Size = new System.Drawing.Size(273, 189);
            this.monitorControl.TabIndex = 7;
            // 
            // registerCycleControl
            // 
            this.registerCycleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerCycleControl.Location = new System.Drawing.Point(288, 419);
            this.registerCycleControl.Margin = new System.Windows.Forms.Padding(5);
            this.registerCycleControl.Name = "registerCycleControl";
            this.registerCycleControl.Size = new System.Drawing.Size(655, 154);
            this.registerCycleControl.TabIndex = 8;
            // 
            // graphControl
            // 
            this.graphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphControl.Location = new System.Drawing.Point(288, 5);
            this.graphControl.Margin = new System.Windows.Forms.Padding(5);
            this.graphControl.Name = "graphControl";
            this.RegisterGrid.SetRowSpan(this.graphControl, 2);
            this.graphControl.Size = new System.Drawing.Size(655, 404);
            this.graphControl.TabIndex = 9;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(5, 204);
            this.settingsControl.Margin = new System.Windows.Forms.Padding(5);
            this.settingsControl.Name = "settingsControl";
            this.RegisterGrid.SetRowSpan(this.settingsControl, 2);
            this.settingsControl.Size = new System.Drawing.Size(273, 369);
            this.settingsControl.TabIndex = 10;
            // 
            // brand
            // 
            this.brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brand.Location = new System.Drawing.Point(0, 583);
            this.brand.Margin = new System.Windows.Forms.Padding(0);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(948, 28);
            this.brand.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(948, 611);
            this.Controls.Add(this.WindowGrid);
            this.MinimumSize = new System.Drawing.Size(964, 650);
            this.Name = "MainForm";
            this.Text = "PRESSURE SYSTEM INFORMATION";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.WindowGrid.ResumeLayout(false);
            this.registerContainer.ResumeLayout(false);
            this.RegisterGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort MainSerialPort;
        private System.Windows.Forms.TableLayoutPanel WindowGrid;
        private System.Windows.Forms.Panel registerContainer;
        private System.Windows.Forms.TableLayoutPanel RegisterGrid;
        private Controls.MonitorControl monitorControl;
        private Controls.RegisterCycleControl registerCycleControl;
        private Controls.GraphControl graphControl;
        private Controls.SettingsControl settingsControl;
        private Controls.BrandControl brand;
    }
}

