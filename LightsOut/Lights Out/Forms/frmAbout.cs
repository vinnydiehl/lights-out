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
using System.Windows.Forms;

namespace LightsOut
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent(); // Load GUI
            this.ActiveControl = lblGameInfo; // Stop txtInfo from being highlighted when the window opens
        }
        private void frmBlank_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowControl.aboutOpen = false;
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
