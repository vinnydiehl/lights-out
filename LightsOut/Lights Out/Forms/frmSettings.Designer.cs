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
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.titleRegion = new System.Windows.Forms.Panel();
            this.chkNewGameOnStart = new System.Windows.Forms.CheckBox();
            this.chkResetClicksOnNewGame = new System.Windows.Forms.CheckBox();
            this.chkNewGameOnCompletion = new System.Windows.Forms.CheckBox();
            this.offPanel = new System.Windows.Forms.Panel();
            this.onPanel = new System.Windows.Forms.Panel();
            this.lblOn = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblColorCustomize = new System.Windows.Forms.Label();
            this.clrDlgOff = new System.Windows.Forms.ColorDialog();
            this.clrDlgOn = new System.Windows.Forms.ColorDialog();
            this.chkLightsOnMode = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlGameMode = new System.Windows.Forms.Panel();
            this.radChallenge = new System.Windows.Forms.RadioButton();
            this.radRelaxed = new System.Windows.Forms.RadioButton();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.chkOnlyLit = new System.Windows.Forms.CheckBox();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dlgSaveGame = new System.Windows.Forms.SaveFileDialog();
            this.dlgLoadGame = new System.Windows.Forms.OpenFileDialog();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pbExitButton = new System.Windows.Forms.PictureBox();
            this.titleRegion.SuspendLayout();
            this.pnlGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).BeginInit();
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
            this.titleRegion.Size = new System.Drawing.Size(372, 30);
            this.titleRegion.TabIndex = 4;
            this.titleRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleRegion_MouseDown);
            // 
            // chkNewGameOnStart
            // 
            this.chkNewGameOnStart.AutoSize = true;
            this.chkNewGameOnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkNewGameOnStart.ForeColor = System.Drawing.Color.LimeGreen;
            this.chkNewGameOnStart.Location = new System.Drawing.Point(12, 36);
            this.chkNewGameOnStart.Name = "chkNewGameOnStart";
            this.chkNewGameOnStart.Size = new System.Drawing.Size(158, 17);
            this.chkNewGameOnStart.TabIndex = 5;
            this.chkNewGameOnStart.Text = "Load New Game on S&tartup";
            this.chkNewGameOnStart.UseVisualStyleBackColor = false;
            this.chkNewGameOnStart.CheckStateChanged += new System.EventHandler(this.checkBoxActivateApply);
            // 
            // chkResetClicksOnNewGame
            // 
            this.chkResetClicksOnNewGame.AutoSize = true;
            this.chkResetClicksOnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkResetClicksOnNewGame.ForeColor = System.Drawing.Color.LimeGreen;
            this.chkResetClicksOnNewGame.Location = new System.Drawing.Point(12, 82);
            this.chkResetClicksOnNewGame.Name = "chkResetClicksOnNewGame";
            this.chkResetClicksOnNewGame.Size = new System.Drawing.Size(156, 17);
            this.chkResetClicksOnNewGame.TabIndex = 5;
            this.chkResetClicksOnNewGame.Text = "&Reset Clicks on New Game";
            this.chkResetClicksOnNewGame.UseVisualStyleBackColor = false;
            this.chkResetClicksOnNewGame.CheckStateChanged += new System.EventHandler(this.checkBoxActivateApply);
            // 
            // chkNewGameOnCompletion
            // 
            this.chkNewGameOnCompletion.AutoSize = true;
            this.chkNewGameOnCompletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkNewGameOnCompletion.ForeColor = System.Drawing.Color.LimeGreen;
            this.chkNewGameOnCompletion.Location = new System.Drawing.Point(12, 59);
            this.chkNewGameOnCompletion.Name = "chkNewGameOnCompletion";
            this.chkNewGameOnCompletion.Size = new System.Drawing.Size(176, 17);
            this.chkNewGameOnCompletion.TabIndex = 5;
            this.chkNewGameOnCompletion.Text = "Load New Game on &Completion";
            this.chkNewGameOnCompletion.UseVisualStyleBackColor = false;
            this.chkNewGameOnCompletion.CheckStateChanged += new System.EventHandler(this.checkBoxActivateApply);
            // 
            // offPanel
            // 
            this.offPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.offPanel.Location = new System.Drawing.Point(203, 48);
            this.offPanel.Name = "offPanel";
            this.offPanel.Size = new System.Drawing.Size(75, 75);
            this.offPanel.TabIndex = 6;
            this.offPanel.DoubleClick += new System.EventHandler(this.offPanel_DoubleClick);
            // 
            // onPanel
            // 
            this.onPanel.BackColor = System.Drawing.Color.Lime;
            this.onPanel.Location = new System.Drawing.Point(284, 48);
            this.onPanel.Name = "onPanel";
            this.onPanel.Size = new System.Drawing.Size(75, 75);
            this.onPanel.TabIndex = 6;
            this.onPanel.DoubleClick += new System.EventHandler(this.onPanel_DoubleClick);
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOn.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblOn.Location = new System.Drawing.Point(309, 32);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(21, 13);
            this.lblOn.TabIndex = 7;
            this.lblOn.Text = "On";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOff.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblOff.Location = new System.Drawing.Point(229, 32);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(21, 13);
            this.lblOff.TabIndex = 7;
            this.lblOff.Text = "Off";
            // 
            // lblColorCustomize
            // 
            this.lblColorCustomize.AutoSize = true;
            this.lblColorCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblColorCustomize.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblColorCustomize.Location = new System.Drawing.Point(199, 126);
            this.lblColorCustomize.Name = "lblColorCustomize";
            this.lblColorCustomize.Size = new System.Drawing.Size(166, 13);
            this.lblColorCustomize.TabIndex = 7;
            this.lblColorCustomize.Text = "Double click a color to customize.";
            // 
            // clrDlgOff
            // 
            this.clrDlgOff.Color = System.Drawing.Color.DarkGreen;
            this.clrDlgOff.FullOpen = true;
            // 
            // clrDlgOn
            // 
            this.clrDlgOn.Color = System.Drawing.Color.Lime;
            this.clrDlgOn.FullOpen = true;
            // 
            // chkLightsOnMode
            // 
            this.chkLightsOnMode.AutoSize = true;
            this.chkLightsOnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkLightsOnMode.ForeColor = System.Drawing.Color.LimeGreen;
            this.chkLightsOnMode.Location = new System.Drawing.Point(12, 105);
            this.chkLightsOnMode.Name = "chkLightsOnMode";
            this.chkLightsOnMode.Size = new System.Drawing.Size(101, 17);
            this.chkLightsOnMode.TabIndex = 5;
            this.chkLightsOnMode.Text = "Lights &On Mode";
            this.chkLightsOnMode.UseVisualStyleBackColor = false;
            this.chkLightsOnMode.CheckStateChanged += new System.EventHandler(this.checkBoxActivateApply);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.toolTip.ForeColor = System.Drawing.Color.LimeGreen;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(218, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(37, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.DarkGreen;
            this.btnApply.Enabled = false;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(321, 210);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(46, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(261, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlGameMode
            // 
            this.pnlGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlGameMode.Controls.Add(this.radChallenge);
            this.pnlGameMode.Controls.Add(this.radRelaxed);
            this.pnlGameMode.Controls.Add(this.lblGameMode);
            this.pnlGameMode.Location = new System.Drawing.Point(5, 158);
            this.pnlGameMode.Name = "pnlGameMode";
            this.pnlGameMode.Size = new System.Drawing.Size(183, 45);
            this.pnlGameMode.TabIndex = 9;
            // 
            // radChallenge
            // 
            this.radChallenge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radChallenge.AutoSize = true;
            this.radChallenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radChallenge.ForeColor = System.Drawing.Color.LimeGreen;
            this.radChallenge.Location = new System.Drawing.Point(17, 19);
            this.radChallenge.Name = "radChallenge";
            this.radChallenge.Size = new System.Drawing.Size(72, 17);
            this.radChallenge.TabIndex = 0;
            this.radChallenge.Text = "C&hallenge";
            this.radChallenge.UseVisualStyleBackColor = false;
            this.radChallenge.CheckedChanged += new System.EventHandler(this.gameModeChanged);
            // 
            // radRelaxed
            // 
            this.radRelaxed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radRelaxed.AutoSize = true;
            this.radRelaxed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radRelaxed.ForeColor = System.Drawing.Color.LimeGreen;
            this.radRelaxed.Location = new System.Drawing.Point(102, 19);
            this.radRelaxed.Name = "radRelaxed";
            this.radRelaxed.Size = new System.Drawing.Size(64, 17);
            this.radRelaxed.TabIndex = 0;
            this.radRelaxed.Text = "Rela&xed";
            this.radRelaxed.UseVisualStyleBackColor = false;
            // 
            // lblGameMode
            // 
            this.lblGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGameMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameMode.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGameMode.Location = new System.Drawing.Point(0, 0);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(183, 23);
            this.lblGameMode.TabIndex = 1;
            this.lblGameMode.Text = "Game Mode";
            this.lblGameMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkOnlyLit
            // 
            this.chkOnlyLit.AutoSize = true;
            this.chkOnlyLit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkOnlyLit.ForeColor = System.Drawing.Color.LimeGreen;
            this.chkOnlyLit.Location = new System.Drawing.Point(12, 128);
            this.chkOnlyLit.Name = "chkOnlyLit";
            this.chkOnlyLit.Size = new System.Drawing.Size(138, 17);
            this.chkOnlyLit.TabIndex = 5;
            this.chkOnlyLit.Text = "O&nly Lit Lights Clickable";
            this.chkOnlyLit.UseVisualStyleBackColor = false;
            this.chkOnlyLit.CheckStateChanged += new System.EventHandler(this.chkOnlyLit_CheckStateChanged);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefaults.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaults.ForeColor = System.Drawing.Color.Black;
            this.btnDefaults.Location = new System.Drawing.Point(5, 210);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(105, 23);
            this.btnDefaults.TabIndex = 8;
            this.btnDefaults.Text = "Restore &Defaults";
            this.btnDefaults.UseVisualStyleBackColor = false;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(231, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save Game";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(231, 176);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "&Load Game";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dlgSaveGame
            // 
            this.dlgSaveGame.DefaultExt = "los";
            this.dlgSaveGame.FileName = "Lights Out";
            this.dlgSaveGame.Filter = "Lights Out Save (*.los)|*.los|All Files ((.*)|*.*";
            this.dlgSaveGame.Title = "Save Game";
            // 
            // dlgLoadGame
            // 
            this.dlgLoadGame.DefaultExt = "los";
            this.dlgLoadGame.Filter = "Lights Out Save (*.los)|*.los|All Files ((.*)|*.*";
            this.dlgLoadGame.Title = "Load Game";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(5, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 20);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            // 
            // pbExitButton
            // 
            this.pbExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbExitButton.Image = global::LightsOut.Properties.Resources.Exit;
            this.pbExitButton.Location = new System.Drawing.Point(347, 5);
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
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(372, 239);
            this.Controls.Add(this.pnlGameMode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDefaults);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblColorCustomize);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.lblOn);
            this.Controls.Add(this.onPanel);
            this.Controls.Add(this.offPanel);
            this.Controls.Add(this.chkOnlyLit);
            this.Controls.Add(this.chkLightsOnMode);
            this.Controls.Add(this.chkResetClicksOnNewGame);
            this.Controls.Add(this.chkNewGameOnCompletion);
            this.Controls.Add(this.chkNewGameOnStart);
            this.Controls.Add(this.titleRegion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.titleRegion.ResumeLayout(false);
            this.titleRegion.PerformLayout();
            this.pnlGameMode.ResumeLayout(false);
            this.pnlGameMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleRegion;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pbExitButton;
        private System.Windows.Forms.CheckBox chkNewGameOnStart;
        private System.Windows.Forms.CheckBox chkResetClicksOnNewGame;
        private System.Windows.Forms.CheckBox chkNewGameOnCompletion;
        private System.Windows.Forms.Panel offPanel;
        private System.Windows.Forms.Panel onPanel;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblColorCustomize;
        private System.Windows.Forms.ColorDialog clrDlgOff;
        private System.Windows.Forms.ColorDialog clrDlgOn;
        private System.Windows.Forms.CheckBox chkLightsOnMode;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlGameMode;
        private System.Windows.Forms.RadioButton radChallenge;
        private System.Windows.Forms.RadioButton radRelaxed;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.CheckBox chkOnlyLit;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog dlgSaveGame;
        private System.Windows.Forms.OpenFileDialog dlgLoadGame;
    }
}