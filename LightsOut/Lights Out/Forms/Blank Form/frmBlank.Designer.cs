namespace LightsOut
{
    partial class frmBlank
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleRegion = new System.Windows.Forms.Panel();
            this.pbMinimizeButton = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pbExitButton = new System.Windows.Forms.PictureBox();
            this.titleRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titleRegion
            // 
            this.titleRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.titleRegion.Controls.Add(this.pbMinimizeButton);
            this.titleRegion.Controls.Add(this.logo);
            this.titleRegion.Controls.Add(this.pbExitButton);
            this.titleRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleRegion.Location = new System.Drawing.Point(0, 0);
            this.titleRegion.Name = "titleRegion";
            this.titleRegion.Size = new System.Drawing.Size(450, 30);
            this.titleRegion.TabIndex = 4;
            this.titleRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleRegion_MouseDown);
            // 
            // pbMinimizeButton
            // 
            this.pbMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizeButton.Image = global::LightsOut.Properties.Resources.Minimize;
            this.pbMinimizeButton.Location = new System.Drawing.Point(399, 5);
            this.pbMinimizeButton.Name = "pbMinimizeButton";
            this.pbMinimizeButton.Size = new System.Drawing.Size(20, 20);
            this.pbMinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMinimizeButton.TabIndex = 2;
            this.pbMinimizeButton.TabStop = false;
            this.pbMinimizeButton.Click += new System.EventHandler(this.pbMinimizeButton_Click);
            this.pbMinimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMinimizeButton_MouseDown);
            this.pbMinimizeButton.MouseEnter += new System.EventHandler(this.pbMinimizeButton_MouseEnter);
            this.pbMinimizeButton.MouseLeave += new System.EventHandler(this.pbMinimizeButton_MouseLeave);
            // 
            // logo
            // 
            this.logo.Image = global::LightsOut.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(88, 20);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // pbExitButton
            // 
            this.pbExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExitButton.Image = global::LightsOut.Properties.Resources.Exit;
            this.pbExitButton.Location = new System.Drawing.Point(425, 5);
            this.pbExitButton.Name = "pbExitButton";
            this.pbExitButton.Size = new System.Drawing.Size(20, 20);
            this.pbExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExitButton.TabIndex = 0;
            this.pbExitButton.TabStop = false;
            this.pbExitButton.Click += new System.EventHandler(this.pbExitButton_Click);
            this.pbExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbExitButton_MouseDown);
            this.pbExitButton.MouseEnter += new System.EventHandler(this.pbExitButton_MouseEnter);
            this.pbExitButton.MouseLeave += new System.EventHandler(this.pbExitButton_MouseLeave);
            // 
            // frmBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.titleRegion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBlank";
            this.ShowIcon = false;
            this.Text = "Blank";
            this.titleRegion.ResumeLayout(false);
            this.titleRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleRegion;
        private System.Windows.Forms.PictureBox pbMinimizeButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pbExitButton;
    }
}