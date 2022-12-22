namespace PressureSystemInformation_Vbeta1
{
    partial class ReportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReportDataControl = new PressureSystemInformation_Vbeta1.Controls.Report.ReportData();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.26061F));
            this.tableLayoutPanel1.Controls.Add(this.ReportDataControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReportViewer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ReportDataControl
            // 
            this.ReportDataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDataControl.Location = new System.Drawing.Point(5, 5);
            this.ReportDataControl.Margin = new System.Windows.Forms.Padding(5);
            this.ReportDataControl.Name = "ReportDataControl";
            this.ReportDataControl.Size = new System.Drawing.Size(271, 547);
            this.ReportDataControl.TabIndex = 1;
            // 
            // ReportViewer
            // 
            this.ReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer.Location = new System.Drawing.Point(286, 5);
            this.ReportViewer.Margin = new System.Windows.Forms.Padding(5);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(722, 547);
            this.ReportViewer.TabIndex = 2;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1013, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportForm";
            this.Text = "Administrador de reportes";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.Report.ReportData ReportDataControl;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
    }
}