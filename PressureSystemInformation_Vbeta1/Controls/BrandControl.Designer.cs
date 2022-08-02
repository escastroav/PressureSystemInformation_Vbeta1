
namespace PressureSystemInformation_Vbeta1.Controls
{
    partial class BrandControl
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
            this.MakimaxLogo = new System.Windows.Forms.PictureBox();
            this.dalebacLogo = new System.Windows.Forms.PictureBox();
            this.BrandText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MakimaxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalebacLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakimaxLogo
            // 
            this.MakimaxLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MakimaxLogo.BackColor = System.Drawing.Color.Transparent;
            this.MakimaxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MakimaxLogo.Image = global::PressureSystemInformation_Vbeta1.Properties.Resources.logoMax;
            this.MakimaxLogo.Location = new System.Drawing.Point(376, 3);
            this.MakimaxLogo.Name = "MakimaxLogo";
            this.MakimaxLogo.Size = new System.Drawing.Size(114, 27);
            this.MakimaxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MakimaxLogo.TabIndex = 1;
            this.MakimaxLogo.TabStop = false;
            // 
            // dalebacLogo
            // 
            this.dalebacLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dalebacLogo.BackColor = System.Drawing.Color.Transparent;
            this.dalebacLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dalebacLogo.Image = global::PressureSystemInformation_Vbeta1.Properties.Resources.dalebac;
            this.dalebacLogo.Location = new System.Drawing.Point(496, 3);
            this.dalebacLogo.Name = "dalebacLogo";
            this.dalebacLogo.Size = new System.Drawing.Size(88, 27);
            this.dalebacLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dalebacLogo.TabIndex = 0;
            this.dalebacLogo.TabStop = false;
            // 
            // BrandText
            // 
            this.BrandText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BrandText.AutoSize = true;
            this.BrandText.Location = new System.Drawing.Point(3, 10);
            this.BrandText.Margin = new System.Windows.Forms.Padding(3);
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(367, 13);
            this.BrandText.TabIndex = 2;
            this.BrandText.Text = "® Pressure System Information (PSI) V 1.0.0 beta  - Dalebac/Makimax S.A.S";
            this.BrandText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BrandText);
            this.flowLayoutPanel1.Controls.Add(this.MakimaxLogo);
            this.flowLayoutPanel1.Controls.Add(this.dalebacLogo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 52);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // BrandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BrandControl";
            this.Size = new System.Drawing.Size(696, 52);
            ((System.ComponentModel.ISupportInitialize)(this.MakimaxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalebacLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox dalebacLogo;
        private System.Windows.Forms.PictureBox MakimaxLogo;
        private System.Windows.Forms.Label BrandText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
