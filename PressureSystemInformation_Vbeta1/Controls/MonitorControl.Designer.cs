
namespace PressureSystemInformation_Vbeta1.Controls
{
    partial class MonitorControl
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
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.DisplayGrid = new System.Windows.Forms.TableLayoutPanel();
            this.dropDisplayPanel = new System.Windows.Forms.Panel();
            this.DropDisplayLabel = new System.Windows.Forms.Label();
            this.DropSubTitle = new System.Windows.Forms.Label();
            this.PressureSubTitle = new System.Windows.Forms.Label();
            this.pressureDisplayPanel = new System.Windows.Forms.Panel();
            this.PressureDisplayLabel = new System.Windows.Forms.Label();
            this.DisplayPanel.SuspendLayout();
            this.DisplayGrid.SuspendLayout();
            this.dropDisplayPanel.SuspendLayout();
            this.pressureDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.DarkGray;
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPanel.Controls.Add(this.DisplayGrid);
            this.DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(5);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(209, 229);
            this.DisplayPanel.TabIndex = 4;
            // 
            // DisplayGrid
            // 
            this.DisplayGrid.ColumnCount = 1;
            this.DisplayGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DisplayGrid.Controls.Add(this.dropDisplayPanel, 0, 3);
            this.DisplayGrid.Controls.Add(this.DropSubTitle, 0, 2);
            this.DisplayGrid.Controls.Add(this.PressureSubTitle, 0, 0);
            this.DisplayGrid.Controls.Add(this.pressureDisplayPanel, 0, 1);
            this.DisplayGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayGrid.Location = new System.Drawing.Point(0, 0);
            this.DisplayGrid.Name = "DisplayGrid";
            this.DisplayGrid.RowCount = 5;
            this.DisplayGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DisplayGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.DisplayGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DisplayGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.DisplayGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DisplayGrid.Size = new System.Drawing.Size(205, 225);
            this.DisplayGrid.TabIndex = 0;
            // 
            // dropDisplayPanel
            // 
            this.dropDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dropDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropDisplayPanel.Controls.Add(this.DropDisplayLabel);
            this.dropDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDisplayPanel.Location = new System.Drawing.Point(50, 98);
            this.dropDisplayPanel.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.dropDisplayPanel.Name = "dropDisplayPanel";
            this.dropDisplayPanel.Size = new System.Drawing.Size(105, 49);
            this.dropDisplayPanel.TabIndex = 3;
            // 
            // DropDisplayLabel
            // 
            this.DropDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DropDisplayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDisplayLabel.ForeColor = System.Drawing.Color.Red;
            this.DropDisplayLabel.Location = new System.Drawing.Point(0, 0);
            this.DropDisplayLabel.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.DropDisplayLabel.Name = "DropDisplayLabel";
            this.DropDisplayLabel.Size = new System.Drawing.Size(101, 45);
            this.DropDisplayLabel.TabIndex = 1;
            this.DropDisplayLabel.Text = "0000.0";
            this.DropDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DropSubTitle
            // 
            this.DropSubTitle.AutoSize = true;
            this.DropSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.DropSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropSubTitle.Location = new System.Drawing.Point(3, 75);
            this.DropSubTitle.Name = "DropSubTitle";
            this.DropSubTitle.Size = new System.Drawing.Size(199, 20);
            this.DropSubTitle.TabIndex = 2;
            this.DropSubTitle.Text = "CAÍDA";
            this.DropSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PressureSubTitle
            // 
            this.PressureSubTitle.AutoSize = true;
            this.PressureSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.PressureSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressureSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureSubTitle.Location = new System.Drawing.Point(3, 0);
            this.PressureSubTitle.Name = "PressureSubTitle";
            this.PressureSubTitle.Size = new System.Drawing.Size(199, 20);
            this.PressureSubTitle.TabIndex = 0;
            this.PressureSubTitle.Text = "PRESIÓN";
            this.PressureSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressureDisplayPanel
            // 
            this.pressureDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pressureDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pressureDisplayPanel.Controls.Add(this.PressureDisplayLabel);
            this.pressureDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pressureDisplayPanel.Location = new System.Drawing.Point(50, 23);
            this.pressureDisplayPanel.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.pressureDisplayPanel.Name = "pressureDisplayPanel";
            this.pressureDisplayPanel.Size = new System.Drawing.Size(105, 49);
            this.pressureDisplayPanel.TabIndex = 1;
            // 
            // PressureDisplayLabel
            // 
            this.PressureDisplayLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureDisplayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PressureDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureDisplayLabel.ForeColor = System.Drawing.Color.Red;
            this.PressureDisplayLabel.Location = new System.Drawing.Point(0, 0);
            this.PressureDisplayLabel.Margin = new System.Windows.Forms.Padding(15, 2, 15, 2);
            this.PressureDisplayLabel.Name = "PressureDisplayLabel";
            this.PressureDisplayLabel.Size = new System.Drawing.Size(101, 45);
            this.PressureDisplayLabel.TabIndex = 0;
            this.PressureDisplayLabel.Text = "0000.0";
            this.PressureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayPanel);
            this.Name = "MonitorControl";
            this.Size = new System.Drawing.Size(209, 229);
            this.Load += new System.EventHandler(this.MonitorControl_Load);
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayGrid.ResumeLayout(false);
            this.DisplayGrid.PerformLayout();
            this.dropDisplayPanel.ResumeLayout(false);
            this.pressureDisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.TableLayoutPanel DisplayGrid;
        private System.Windows.Forms.Panel dropDisplayPanel;
        private System.Windows.Forms.Label DropDisplayLabel;
        private System.Windows.Forms.Label DropSubTitle;
        private System.Windows.Forms.Label PressureSubTitle;
        private System.Windows.Forms.Panel pressureDisplayPanel;
        private System.Windows.Forms.Label PressureDisplayLabel;
    }
}
