
namespace PressureSystemInformation_Vbeta1.Controls
{
    partial class COMControl
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
            this.COMPanel = new System.Windows.Forms.Panel();
            this.COMGrid = new System.Windows.Forms.TableLayoutPanel();
            this.SampleTimeLabel = new System.Windows.Forms.Label();
            this.COMSubTitle = new System.Windows.Forms.Label();
            this.COMTitle = new System.Windows.Forms.Label();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.SampleTimeTextBox = new System.Windows.Forms.TextBox();
            this.COMPanel.SuspendLayout();
            this.COMGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPanel
            // 
            this.COMPanel.BackColor = System.Drawing.Color.DarkGray;
            this.COMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.COMPanel.Controls.Add(this.COMGrid);
            this.COMPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMPanel.Location = new System.Drawing.Point(0, 0);
            this.COMPanel.Margin = new System.Windows.Forms.Padding(5);
            this.COMPanel.Name = "COMPanel";
            this.COMPanel.Size = new System.Drawing.Size(273, 150);
            this.COMPanel.TabIndex = 2;
            // 
            // COMGrid
            // 
            this.COMGrid.ColumnCount = 2;
            this.COMGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.COMGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.COMGrid.Controls.Add(this.SampleTimeLabel, 0, 3);
            this.COMGrid.Controls.Add(this.COMSubTitle, 0, 1);
            this.COMGrid.Controls.Add(this.COMTitle, 0, 0);
            this.COMGrid.Controls.Add(this.COMComboBox, 1, 1);
            this.COMGrid.Controls.Add(this.SampleTimeTextBox, 1, 3);
            this.COMGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMGrid.Location = new System.Drawing.Point(0, 0);
            this.COMGrid.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.COMGrid.Name = "COMGrid";
            this.COMGrid.RowCount = 7;
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.COMGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.COMGrid.Size = new System.Drawing.Size(269, 146);
            this.COMGrid.TabIndex = 0;
            // 
            // SampleTimeLabel
            // 
            this.SampleTimeLabel.AutoSize = true;
            this.SampleTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SampleTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleTimeLabel.Location = new System.Drawing.Point(3, 67);
            this.SampleTimeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SampleTimeLabel.Name = "SampleTimeLabel";
            this.SampleTimeLabel.Size = new System.Drawing.Size(128, 16);
            this.SampleTimeLabel.TabIndex = 9;
            this.SampleTimeLabel.Text = "Muestreo (ms)";
            this.SampleTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // COMSubTitle
            // 
            this.COMSubTitle.AutoSize = true;
            this.COMSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.COMSubTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMSubTitle.Location = new System.Drawing.Point(3, 40);
            this.COMSubTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.COMSubTitle.Name = "COMSubTitle";
            this.COMSubTitle.Size = new System.Drawing.Size(128, 17);
            this.COMSubTitle.TabIndex = 2;
            this.COMSubTitle.Text = "COM";
            this.COMSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // COMTitle
            // 
            this.COMTitle.AutoSize = true;
            this.COMTitle.BackColor = System.Drawing.Color.Transparent;
            this.COMGrid.SetColumnSpan(this.COMTitle, 2);
            this.COMTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMTitle.Location = new System.Drawing.Point(3, 15);
            this.COMTitle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 5);
            this.COMTitle.Name = "COMTitle";
            this.COMTitle.Size = new System.Drawing.Size(263, 15);
            this.COMTitle.TabIndex = 1;
            this.COMTitle.Text = "CONEXIÓN CON DISPOSITIVO";
            this.COMTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // COMComboBox
            // 
            this.COMComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Location = new System.Drawing.Point(137, 38);
            this.COMComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(112, 21);
            this.COMComboBox.TabIndex = 3;
            // 
            // SampleTimeTextBox
            // 
            this.SampleTimeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleTimeTextBox.Location = new System.Drawing.Point(137, 65);
            this.SampleTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.SampleTimeTextBox.Name = "SampleTimeTextBox";
            this.SampleTimeTextBox.Size = new System.Drawing.Size(112, 20);
            this.SampleTimeTextBox.TabIndex = 10;
            // 
            // COMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.COMPanel);
            this.Name = "COMControl";
            this.Size = new System.Drawing.Size(273, 150);
            this.COMPanel.ResumeLayout(false);
            this.COMGrid.ResumeLayout(false);
            this.COMGrid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel COMPanel;
        private System.Windows.Forms.TableLayoutPanel COMGrid;
        private System.Windows.Forms.Label SampleTimeLabel;
        private System.Windows.Forms.Label COMSubTitle;
        private System.Windows.Forms.Label COMTitle;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.Windows.Forms.TextBox SampleTimeTextBox;
    }
}
