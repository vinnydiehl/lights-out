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

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class frmSettings : Form
    {
        private frmMain parent;
        private bool newOnApply = false;
        private bool onlyLitChanged = false;

        public frmSettings(frmMain _parent)
        {
            InitializeComponent(); // Load GUI
            parent = _parent; // We need the parent frmMain
            
            // Load current settings into GUI
            chkNewGameOnStart.Checked = Settings.newGameOnStart;
            chkNewGameOnCompletion.Checked = Settings.newGameOnCompletion;
            chkResetClicksOnNewGame.Checked = Settings.resetClicksOnNewGame;
            chkLightsOnMode.Checked = Settings.lightsOnMode;
            chkOnlyLit.Checked = Settings.onlyLit;
            if (Defaults.gameMode == "C") radChallenge.Checked = true;
            else radRelaxed.Checked = true;
            clrDlgOff.Color = offPanel.BackColor = Settings.offColor;
            clrDlgOn.Color = onPanel.BackColor = Settings.onColor;

            // Changing the checkboxes while loading them will activate btnApply, stop that
            btnApply.Enabled = false;

            // ToolTips
            toolTip.SetToolTip(chkNewGameOnStart, "Load a new game when the application is starting.");
            toolTip.SetToolTip(chkNewGameOnCompletion, "Load a new game automatically when you win the current game.");
            toolTip.SetToolTip(chkResetClicksOnNewGame, "Reset the clicks counter when a new game starts.");
            toolTip.SetToolTip(chkLightsOnMode, "Turn all lights on to win rather than off.");
            toolTip.SetToolTip(chkOnlyLit, "Only lights that are lit will be clickable.");
            toolTip.SetToolTip(radChallenge, "Solve the puzzle before you run out of clicks.");
            toolTip.SetToolTip(radRelaxed, "You have unlimited clicks to solve the puzzle.");
            toolTip.SetToolTip(offPanel, "Double click to set the color of the off light.");
            toolTip.SetToolTip(onPanel, "Double click to set the color of the on light.");
        }
        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowControl.settingsOpen = false;
        }

        public void saveAndApplySettings()
        {
            SettingsWriter writer = new SettingsWriter(Sys.APPDATA_DIR_NAME, Settings.SETTINGS_FILE);

            // Save settings

            writer.Save("NewGameOnStart", chkNewGameOnStart.Checked ? "1" : "0");
            writer.Save("NewGameOnCompletion", chkNewGameOnCompletion.Checked ? "1" : "0");
            writer.Save("ResetClicksOnNewGame", chkResetClicksOnNewGame.Checked ? "1" : "0");
            writer.Save("LightsOnMode", chkLightsOnMode.Checked ? "1" : "0");
            writer.Save("OnlyLit", chkOnlyLit.Checked ? "1" : "0");
            writer.Save("GameMode", radRelaxed.Checked ? "R" : "C");
            writer.Save("OffColor", ColorTranslator.ToHtml(clrDlgOff.Color));
            writer.Save("OnColor", ColorTranslator.ToHtml(clrDlgOn.Color));

            writer.Close(); // Close the SettingsWriter's internal StreamWriter

            // Apply settings

            if (newOnApply && // Makes sure this only happens when the game mode changes from the previous state:
               ((Settings.gameMode == "R" && radChallenge.Checked) || (Settings.gameMode == "C" && radRelaxed.Checked)) )
            {
                // Changing the game mode starts a new game, also update lblStatus
                Settings.gameMode = radRelaxed.Checked ? "R" : "C";
                parent.newGame();
                frmMain.setStatus(parent, "Game Mode\nChanged");
            }
            if (onlyLitChanged && chkOnlyLit.Checked && !Settings.onlyLit && frmMain.checkNewGame())
            {
                // If they turn on OnlyLit but the current board is blank, start a new game when they apply
                Settings.onlyLit = chkOnlyLit.Checked;
                parent.newGame();
                frmMain.setStatus(parent, "Settings\nChanged");
            }
            if ( (Settings.newGameOnStart != chkNewGameOnStart.Checked) ||
                 (Settings.newGameOnCompletion != chkNewGameOnCompletion.Checked) ||
                 (Settings.resetClicksOnNewGame != chkResetClicksOnNewGame.Checked) ||
                 (Settings.lightsOnMode != chkLightsOnMode.Checked) ||
                 (Settings.offColor != clrDlgOff.Color) || (Settings.onColor != clrDlgOn.Color) )
            {
                // If any settings have been changed from before, they are all applied and the
                // "Settings Changed" message is displayed. If they just, for example, checked and then
                // unchecked a box, and all values are the same as before, nothing happens.

                Settings.newGameOnStart = chkNewGameOnStart.Checked;
                Settings.newGameOnCompletion = chkNewGameOnCompletion.Checked;
                Settings.resetClicksOnNewGame = chkResetClicksOnNewGame.Checked;
                Settings.lightsOnMode = chkLightsOnMode.Checked;
                Settings.colorShift(); // Store the old colors so the change can be applied to the grid
                Settings.offColor = clrDlgOff.Color;
                Settings.onColor = clrDlgOn.Color;

                frmMain.setColors();

                frmMain.setStatus(parent, "Settings\nChanged");
            }

            newOnApply = onlyLitChanged = false; // Reset any booleans for tracking that may have been on
        }

        /*** Color Selection ***/

        private void offPanel_DoubleClick(object sender, EventArgs e)
        {
            if (clrDlgOff.ShowDialog() == DialogResult.OK)
            {
                offPanel.BackColor = clrDlgOff.Color;
                btnApply.Enabled = true;
            }
        }
        private void onPanel_DoubleClick(object sender, EventArgs e)
        {
            if (clrDlgOn.ShowDialog() == DialogResult.OK)
            {
                onPanel.BackColor = clrDlgOn.Color;
                btnApply.Enabled = true;
            }
        }

        /*** Change Management ***/

        private void gameModeChanged(object sender, EventArgs e)
        {
            newOnApply = true; // Changing the game mode starts a new game when applied
            btnApply.Enabled = true; // Also enables btnApply
        }

        private void checkBoxActivateApply(object sender, EventArgs e)
        {
            // Changing any of the checkboxes enables the apply button
            btnApply.Enabled = true;
        }

        private void chkOnlyLit_CheckStateChanged(object sender, EventArgs e)
        {
            checkBoxActivateApply(sender, e); // Enable the apply button
            onlyLitChanged = true; // Indicates that this was changed
        }

        /*** Buttons ***/

        /// Exit Button

        // Light up on hover
        private void pbExitButton_MouseEnter(object sender, EventArgs e)
        { pbExitButton.Image = global::LightsOut.Properties.Resources.Exit_Hover; }
        private void pbExitButton_MouseLeave(object sender, EventArgs e)
        { pbExitButton.Image = global::LightsOut.Properties.Resources.Exit; }
        // Darken on mouse down
        private void pbExitButton_MouseDown(object sender, MouseEventArgs e)
        { pbExitButton.Image = global::LightsOut.Properties.Resources.Exit_Mouse_Down; }
        // Exit application on click
        private void pbExitButton_Click(object sender, EventArgs e) { this.Close(); }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // OK button will save and apply settings, then close the form
            saveAndApplySettings();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel button will close the form without saving or applying anything
            this.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Apply button will save and apply settings, keeping the form open
            saveAndApplySettings();
            btnApply.Enabled = false; // Stops spamming and lets the user know if they've changed anything
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            // Restores the default settings to the settings window - does not apply them
            chkNewGameOnStart.Checked = Defaults.newGameOnStart;
            chkNewGameOnCompletion.Checked = Defaults.newGameOnCompletion;
            chkResetClicksOnNewGame.Checked = Defaults.resetClicksOnNewGame;
            chkLightsOnMode.Checked = Defaults.lightsOnMode;
            chkOnlyLit.Checked = Defaults.onlyLit;
            if (Defaults.gameMode == "C") radChallenge.Checked = true;
            else radRelaxed.Checked = true;
            clrDlgOff.Color = offPanel.BackColor = Defaults.offColor;
            clrDlgOn.Color = onPanel.BackColor = Defaults.onColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSaveGame.ShowDialog() == DialogResult.OK)
                SaveState.Save(frmMain.tiles, frmMain.clicks, dlgSaveGame.FileName);

            frmMain.setStatus(parent, "Game\nSaved");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dlgLoadGame.ShowDialog() == DialogResult.OK)
            {
                List<string> save = SaveState.Load(dlgLoadGame.FileName);

                // The first number on the save state will be the clicks
                // Use Math.Abs in case they try to edit in a negative number
                frmMain.clicks = Math.Abs(Convert.ToInt32(save[0]));
                frmMain.setCounter(parent);

                // The next number on the save state will be the game mode
                // Don't set this directly; use a ternary to protect against them editing the save state
                Settings.gameMode = save[1] == "C" ? "C" : "R";
                if (Defaults.gameMode == "C") radChallenge.Checked = true;
                else radRelaxed.Checked = true;
                
                save.RemoveRange(0, 2); // Remove everything except for the tile states

                for (int i = 0; i < save.Count; ++i)
                    frmMain.tiles[i].BackColor = save[i] == "1" ? Settings.onColor : Settings.offColor;

                frmMain.setStatus(parent, "Save\nLoaded");
            }
        }

        /*** Allow user to drag window around via titleRegion ***/

        public void dragWindow(MouseButtons btn)
        {
            if (btn == MouseButtons.Left)
            {
                Sys.ReleaseCapture();
                Sys.SendMessage(Handle, Sys.WM_NCLBUTTONDOWN, Sys.HT_CAPTION, 0);
            }
        }

        private void titleRegion_MouseDown(object sender, MouseEventArgs e) { dragWindow(e.Button); }
        private void logo_MouseDown(object sender, MouseEventArgs e) { dragWindow(e.Button); }
    }
}
