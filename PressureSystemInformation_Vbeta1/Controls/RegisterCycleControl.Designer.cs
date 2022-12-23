
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CyclesRegisterPanel = new System.Windows.Forms.Panel();
            this.CyclesRegisterGrid = new System.Windows.Forms.TableLayoutPanel();
            this.CyclesRegisterLabel = new System.Windows.Forms.Label();
            this.CyclesRegisterList = new System.Windows.Forms.DataGridView();
            this.leakCycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cycleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressurePeak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDrop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CyclesRegisterPanel.SuspendLayout();
            this.CyclesRegisterGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesRegisterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leakCycleBindingSource)).BeginInit();
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
            this.CyclesRegisterPanel.Size = new System.Drawing.Size(602, 140);
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
            this.CyclesRegisterGrid.Size = new System.Drawing.Size(598, 136);
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
            this.CyclesRegisterLabel.Size = new System.Drawing.Size(592, 15);
            this.CyclesRegisterLabel.TabIndex = 2;
            this.CyclesRegisterLabel.Text = "REGISTRO DE CICLOS";
            this.CyclesRegisterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CyclesRegisterList
            // 
            this.CyclesRegisterList.AllowUserToAddRows = false;
            this.CyclesRegisterList.AllowUserToDeleteRows = false;
            this.CyclesRegisterList.AutoGenerateColumns = false;
            this.CyclesRegisterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CyclesRegisterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cycleID,
            this.startDate,
            this.cycleTime,
            this.pressurePeak,
            this.pressureDrop,
            this.pass});
            this.CyclesRegisterList.DataSource = this.leakCycleBindingSource;
            this.CyclesRegisterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CyclesRegisterList.Location = new System.Drawing.Point(20, 33);
            this.CyclesRegisterList.Margin = new System.Windows.Forms.Padding(20, 5, 20, 15);
            this.CyclesRegisterList.Name = "CyclesRegisterList";
            this.CyclesRegisterList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CyclesRegisterList.RowHeadersVisible = false;
            this.CyclesRegisterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CyclesRegisterList.Size = new System.Drawing.Size(558, 91);
            this.CyclesRegisterList.TabIndex = 3;
            // 
            // leakCycleBindingSource
            // 
            this.leakCycleBindingSource.DataSource = typeof(PressureSystemInformation_Vbeta1.Test.LeakCycle);
            // 
            // cycleID
            // 
            this.cycleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cycleID.DataPropertyName = "CycleID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cycleID.DefaultCellStyle = dataGridViewCellStyle1;
            this.cycleID.HeaderText = "Prueba No.";
            this.cycleID.Name = "cycleID";
            this.cycleID.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDate.DataPropertyName = "StartDate";
            this.startDate.HeaderText = "Hora y fecha";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // cycleTime
            // 
            this.cycleTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cycleTime.DataPropertyName = "CycleTime";
            this.cycleTime.HeaderText = "Duración (seg)";
            this.cycleTime.Name = "cycleTime";
            this.cycleTime.ReadOnly = true;
            // 
            // pressurePeak
            // 
            this.pressurePeak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pressurePeak.DataPropertyName = "PressurePeak";
            this.pressurePeak.HeaderText = "Máximo (PSI)";
            this.pressurePeak.Name = "pressurePeak";
            this.pressurePeak.ReadOnly = true;
            // 
            // pressureDrop
            // 
            this.pressureDrop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pressureDrop.DataPropertyName = "PressureDrop";
            this.pressureDrop.HeaderText = "Caída (PSI)";
            this.pressureDrop.Name = "pressureDrop";
            this.pressureDrop.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pass.DataPropertyName = "Pass";
            this.pass.FalseValue = "NO APROBADO";
            this.pass.HeaderText = "Aprobado?";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.TrueValue = "APROBADO";
            // 
            // RegisterCycleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CyclesRegisterPanel);
            this.Name = "RegisterCycleControl";
            this.Size = new System.Drawing.Size(602, 140);
            this.CyclesRegisterPanel.ResumeLayout(false);
            this.CyclesRegisterGrid.ResumeLayout(false);
            this.CyclesRegisterGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CyclesRegisterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leakCycleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CyclesRegisterPanel;
        private System.Windows.Forms.TableLayoutPanel CyclesRegisterGrid;
        private System.Windows.Forms.Label CyclesRegisterLabel;
        private System.Windows.Forms.DataGridView CyclesRegisterList;
        private System.Windows.Forms.BindingSource leakCycleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressurePeak;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDrop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pass;
    }
}
