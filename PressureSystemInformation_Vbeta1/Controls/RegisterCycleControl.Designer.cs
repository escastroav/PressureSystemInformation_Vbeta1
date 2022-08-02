
namespace PressureSystemInformation_Vbeta1.Controls
{
    partial class RegisterCycleControl
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
            this.CyclesRegisterPanel = new System.Windows.Forms.Panel();
            this.CyclesRegisterGrid = new System.Windows.Forms.TableLayoutPanel();
            this.CyclesRegisterLabel = new System.Windows.Forms.Label();
            this.CyclesRegisterList = new System.Windows.Forms.DataGridView();
            this.CyclesRegisterPanel.SuspendLayout();
            this.CyclesRegisterGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesRegisterList)).BeginInit();
            this.SuspendLayout();
            // 
            // CyclesRegisterPanel
            // 
            this.CyclesRegisterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.CyclesRegisterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CyclesRegisterPanel.Controls.Add(this.CyclesRegisterGrid);
            this.CyclesRegisterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyclesRegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.CyclesRegisterPanel.Margin = new System.Windows.Forms.Padding(5);
            this.CyclesRegisterPanel.Name = "CyclesRegisterPanel";
            this.CyclesRegisterPanel.Size = new System.Drawing.Size(150, 150);
            this.CyclesRegisterPanel.TabIndex = 5;
            // 
            // CyclesRegisterGrid
            // 
            this.CyclesRegisterGrid.ColumnCount = 1;
            this.CyclesRegisterGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CyclesRegisterGrid.Controls.Add(this.CyclesRegisterLabel, 0, 0);
            this.CyclesRegisterGrid.Controls.Add(this.CyclesRegisterList, 0, 1);
            this.CyclesRegisterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyclesRegisterGrid.Location = new System.Drawing.Point(0, 0);
            this.CyclesRegisterGrid.Name = "CyclesRegisterGrid";
            this.CyclesRegisterGrid.RowCount = 2;
            this.CyclesRegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CyclesRegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CyclesRegisterGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CyclesRegisterGrid.Size = new System.Drawing.Size(146, 146);
            this.CyclesRegisterGrid.TabIndex = 0;
            // 
            // CyclesRegisterLabel
            // 
            this.CyclesRegisterLabel.AutoSize = true;
            this.CyclesRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.CyclesRegisterGrid.SetColumnSpan(this.CyclesRegisterLabel, 2);
            this.CyclesRegisterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyclesRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyclesRegisterLabel.Location = new System.Drawing.Point(3, 10);
            this.CyclesRegisterLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.CyclesRegisterLabel.Name = "CyclesRegisterLabel";
            this.CyclesRegisterLabel.Size = new System.Drawing.Size(140, 30);
            this.CyclesRegisterLabel.TabIndex = 2;
            this.CyclesRegisterLabel.Text = "REGISTRO DE CICLOS";
            this.CyclesRegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CyclesRegisterList
            // 
            this.CyclesRegisterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CyclesRegisterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyclesRegisterList.Location = new System.Drawing.Point(20, 48);
            this.CyclesRegisterList.Margin = new System.Windows.Forms.Padding(20, 5, 20, 15);
            this.CyclesRegisterList.Name = "CyclesRegisterList";
            this.CyclesRegisterList.Size = new System.Drawing.Size(106, 91);
            this.CyclesRegisterList.TabIndex = 3;
            // 
            // RegisterCycleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CyclesRegisterPanel);
            this.Name = "RegisterCycleControl";
            this.CyclesRegisterPanel.ResumeLayout(false);
            this.CyclesRegisterGrid.ResumeLayout(false);
            this.CyclesRegisterGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesRegisterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CyclesRegisterPanel;
        private System.Windows.Forms.TableLayoutPanel CyclesRegisterGrid;
        private System.Windows.Forms.Label CyclesRegisterLabel;
        private System.Windows.Forms.DataGridView CyclesRegisterList;
    }
}
