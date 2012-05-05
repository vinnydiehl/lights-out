/**
 * Lights Out - A grid-based puzzle game.
 * Copyright (C) 2012 Vinny Diehl
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
**/

namespace LightsOut
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.titleRegion = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pbExitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.titleRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleRegion
            // 
            this.titleRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.titleRegion.Controls.Add(this.logo);
            this.titleRegion.Controls.Add(this.pbExitButton);
            this.titleRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleRegion.Location = new System.Drawing.Point(0, 0);
            this.titleRegion.Name = "titleRegion";
            this.titleRegion.Size = new System.Drawing.Size(433, 30);
            this.titleRegion.TabIndex = 4;
            this.titleRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleRegion_MouseDown);
            // 
            // logo
            // 
            this.logo.Image = global::LightsOut.Properties.Resources.AboutText;
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(52, 20);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // pbExitButton
            // 
            this.pbExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExitButton.Image = global::LightsOut.Properties.Resources.Exit;
            this.pbExitButton.Location = new System.Drawing.Point(408, 5);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightsOut.Properties.Resources.Light_Bulb;
            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblName.Location = new System.Drawing.Point(157, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: Lights Out";
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGameInfo.Location = new System.Drawing.Point(237, 34);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(96, 24);
            this.lblGameInfo.TabIndex = 6;
            this.lblGameInfo.Text = "Game Info";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblVersion.Location = new System.Drawing.Point(157, 94);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 13);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version: 1.0";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDeveloper.Location = new System.Drawing.Point(157, 117);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(128, 13);
            this.lblDeveloper.TabIndex = 6;
            this.lblDeveloper.Text = "Developer: Chaos Utilities";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtInfo.Location = new System.Drawing.Point(12, 158);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(409, 122);
            this.txtInfo.TabIndex = 7;
            this.txtInfo.Text = resources.GetString("txtInfo.Text");
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(433, 292);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.titleRegion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Lights Out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBlank_FormClosing);
            this.titleRegion.ResumeLayout(false);
            this.titleRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleRegion;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pbExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.TextBox txtInfo;
    }
}