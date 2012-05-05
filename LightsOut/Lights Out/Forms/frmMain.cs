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
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LightsOut
{
    public partial class frmMain : Form
    {
        public static List<Panel> tiles;
        public static int clicks = 0;

        // For font installation:
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();

        public frmMain() // Main form constructor
        {
            InitializeComponent(); // Load GUI

            try // Install Gill Sans MT Bold
            {
                unsafe
                {
                    byte[] font = Properties.Resources.Gill_Sans_MT_Bold;
                    fixed (byte *pFontData = font)
                    {
                        uint dummy = 0;
                        fonts.AddMemoryFont((IntPtr)pFontData, font.Length);
                        AddFontMemResourceEx((IntPtr)pFontData, (uint)font.Length, IntPtr.Zero, ref dummy);
                    }
                }
                // Set that to lblClicks
                lblClicks.Font = new System.Drawing.Font(fonts.Families[0], 50.25F,
                                                         System.Drawing.FontStyle.Bold,
                                                         System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            catch
            {
                // If the font didn't install, move the clicks counter to where the default font
                // looks as good as it can (5 pixels lower)
                pnlHolder_lblClicks.Location = new Point(pnlHolder_lblClicks.Location.X,
                                                         pnlHolder_lblClicks.Location.Y - 5);
            }

            tiles = new List<Panel>() // Compile a list of the tiles
            {
                panel1, panel2, panel3, panel4, panel5,
                panel6, panel7, panel8, panel9, panel10,
                panel11, panel12, panel13, panel14, panel15,
                panel16, panel17, panel18, panel19, panel20,
                panel21, panel22, panel23, panel24, panel25
            };

            loadSettings(); // Load settings into Settings class on startup
            setColors(); // Set the colors chosen in the settings to the tiles in the list

            if (Settings.newGameOnStart) newGame();
        }

        /*** Game Management ***/

        public void newGame()
        {
            Random rand = new Random();

            for (int i = 0; i < tiles.Count; ++i)
                if (rand.Next(0, 2) == 1)
                {
                    activate(i);
                    // We don't want these to affect the clicks counter:
                    clicks += Settings.gameMode == "R" ? -1 : 1;
                }

            // Reset clicks counter if resetClicksOnNewGame is enabled
            if (Settings.resetClicksOnNewGame) clicks = Settings.gameMode == "C" ? 15 : 0;

            // Test if a panel is disabled, if it is, make sure they're all on
            if (!tiles[0].Enabled)
                foreach (Panel tile in tiles)
                    tile.Enabled = true;

            setCounter();
        }
        // For external access:
        public static void newGame(frmMain sender) { sender.newGame(); }

        public static void setStatus(frmMain sender, string str) // For changing lblStatus externally
        {
            sender.lblStatus.Text = str;
        }

        /*** Tile Management ***/

        public void activate(int index) // Toggles a tile and its neighbors
        {
            /**
             * Form a list of all of the tiles to toggle.
             * [-1, 1, -5, 5] are the neighbors for a 5x5 grid.
            **/

            List<Panel> neighbors = new List<Panel>() { tiles[index] }; // Start with the index

            // Checking <24, >4, and <20 stop IndexOutOfRange exceptions
            // Checking index%5!=0 stops 5 from toggling 4, etc.
            // Checking (index+1)%5!=0 stops 4 from toggling 5, etc.
            if (index % 5 != 0)
                neighbors.Add(tiles[index - 1]); // Tile to the right
            if ((index + 1) % 5 != 0 && index < 24)
                neighbors.Add(tiles[index + 1]); // Tile to the left
            if (index > 4)
                neighbors.Add(tiles[index - 5]); // Tile above
            if (index < 20)
                neighbors.Add(tiles[index + 5]); // Tile below

            // Toggle all of the neighbors
            foreach (Panel neighbor in neighbors)
                toggle(neighbor);

            // Increment or decrement the click counter
            clicks += Settings.gameMode == "R" ? 1 : -1;
            setCounter();

            checkLights(); // See if they've won the game

            if (Settings.gameMode == "C" && clicks < 1) // If the counter reaches 0 on Challenge mode
            {
                lblStatus.Text = "You\nLose!";
                if (Settings.newGameOnCompletion) newGame();
                else foreach (Panel tile in tiles) tile.Enabled = false;
            }
        }
        private void clickTile(object sender, MouseEventArgs e) // Fired when a tile is clicked
        {
            Panel tile = sender as Panel;
            if ((Settings.onlyLit && tile.BackColor == Settings.onColor) || !Settings.onlyLit)
                activate(tiles.IndexOf(tile));
        }

        public void toggle(Panel tile) // Toggles tile on/off
        {
            // Toggle the panel's background color
            tile.BackColor = tile.BackColor == Settings.offColor ? Settings.onColor : Settings.offColor;
        }

        public void checkLights(bool initialCheck=false) // Checks the panels for a win
        {
            bool win = true;

            foreach (Panel tile in tiles)
                if ((!Settings.lightsOnMode && tile.BackColor == Settings.onColor) ||
                    (Settings.lightsOnMode && tile.BackColor == Settings.offColor))
                    win = false;

            if (win)
            {
                lblStatus.Text = !Settings.lightsOnMode ? "Lights\nOff!" : "Lights\nOn!";
                if (Settings.newGameOnCompletion && !initialCheck)
                {
                    newGame(); // Start a new game if enabled in settings
                    lblStatus.Text = "You\nWon!"; // In this case just have a generic temporary label
                }
            }
            else lblStatus.Text = !Settings.lightsOnMode ? "Lights\nOn..." : "Lights\nOff...";
        }

        public static bool checkNewGame() // Returns true if all lights are off, false otherwise
        {
            foreach (Panel tile in tiles)
                if (tile.BackColor == Settings.onColor)
                    return false;
            return true;
        }

        public void setCounter() // Set the clicks counter to display the current value of clicks
        {
            lblClicks.Text = clicks.ToString();
        }
        // For external access:
        public static void setCounter(frmMain sender) { sender.setCounter(); }

        /*** Settings ***/

        private void loadSettings()
        {
            SettingsReader reader = new SettingsReader(Sys.APPDATA_DIR_NAME, Settings.SETTINGS_FILE);

            string val; // Settings will be loaded into here for evaluation

            if ((val = reader.Load("NewGameOnStart")) != null) Settings.newGameOnStart = (val == "1");
            if ((val = reader.Load("NewGameOnCompletion")) != null) Settings.newGameOnCompletion = (val == "1");
            if ((val = reader.Load("ResetClicksOnNewGame")) != null) Settings.resetClicksOnNewGame = (val == "1");
            if ((val = reader.Load("LightsOnMode")) != null) Settings.lightsOnMode = (val == "1");
            if ((val = reader.Load("OnlyLit")) != null) Settings.onlyLit = (val == "1");
            if ((val = reader.Load("GameMode")) != null) Settings.gameMode = val;
            if ((val = reader.Load("OffColor")) != null) Settings.offColor = ColorTranslator.FromHtml(val);
            if ((val = reader.Load("OnColor")) != null) Settings.onColor = ColorTranslator.FromHtml(val);
        }

        public static void setColors() // Sets the colors of the tiles to those defined in Settings
        {
            foreach (Panel tile in tiles)
                tile.BackColor = tile.BackColor == Settings.previousOffColor ? Settings.offColor : Settings.onColor;
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

        /// Minimize Button

        // Light up on hover
        private void pbMinimizeButton_MouseEnter(object sender, EventArgs e)
            { pbMinimizeButton.Image = global::LightsOut.Properties.Resources.Minimize_Hover; }
        private void pbMinimizeButton_MouseLeave(object sender, EventArgs e)
            { pbMinimizeButton.Image = global::LightsOut.Properties.Resources.Minimize; }
        // Darken on mouse down
        private void pbMinimizeButton_MouseDown(object sender, MouseEventArgs e)
            { pbMinimizeButton.Image = global::LightsOut.Properties.Resources.Minimize_Mouse_Down; }
        // Minimize application on click
        private void pbMinimizeButton_Click(object sender, EventArgs e)
            { this.WindowState = FormWindowState.Minimized; }

        /// New Game Button

        // Light up on hover
        private void pbNewGameButton_MouseEnter(object sender, EventArgs e)
            { pbNewGameButton.Image = global::LightsOut.Properties.Resources.New_Game_Hover; }
        private void pbNewGameButton_MouseLeave(object sender, EventArgs e)
            { pbNewGameButton.Image = global::LightsOut.Properties.Resources.New_Game; }
        // Darken on mouse down
        private void pbNewGameButton_MouseDown(object sender, MouseEventArgs e)
            { pbNewGameButton.Image = global::LightsOut.Properties.Resources.New_Game_Mouse_Down; }
        // Back to normal on mouse up
        private void pbNewGameButton_MouseUp(object sender, MouseEventArgs e)
            { pbNewGameButton.Image = global::LightsOut.Properties.Resources.New_Game; }
        // Clicking fires newGame()
        private void pbNewGameButton_Click(object sender, EventArgs e) { newGame(); }

        /// About Button

        // Light up on hover
        private void pbAboutButton_MouseEnter(object sender, EventArgs e)
            { pbAboutButton.Image = global::LightsOut.Properties.Resources.About_Hover; }
        private void pbAboutButton_MouseLeave(object sender, EventArgs e)
            { pbAboutButton.Image = global::LightsOut.Properties.Resources.About; }
        // Darken on mouse down
        private void pbAboutButton_MouseDown(object sender, MouseEventArgs e)
            { pbAboutButton.Image = global::LightsOut.Properties.Resources.About_Mouse_Down; }
        // Back to normal on mouse up
        private void pbAboutButton_MouseUp(object sender, MouseEventArgs e)
            { pbAboutButton.Image = global::LightsOut.Properties.Resources.About; }
        // Clicking opens a new frmAbout
        private void pbAboutButton_Click(object sender, EventArgs e)
        {
            if (!WindowControl.aboutOpen) new frmAbout().Show();
            WindowControl.aboutOpen = true;
        }

        /// Settings Button

        // Light up on hover
        private void pbSettingsButton_MouseEnter(object sender, EventArgs e)
            { pbSettingsButton.Image = global::LightsOut.Properties.Resources.Settings_Hover; }
        private void pbSettingsButton_MouseLeave(object sender, EventArgs e)
            { pbSettingsButton.Image = global::LightsOut.Properties.Resources.Settings; }
        // Darken on mouse down
        private void pbSettingsButton_MouseDown(object sender, MouseEventArgs e)
            { pbSettingsButton.Image = global::LightsOut.Properties.Resources.Settings_Mouse_Down; }
        // Back to normal on mouse up
        private void pbSettingsButton_MouseUp(object sender, MouseEventArgs e)
            { pbSettingsButton.Image = global::LightsOut.Properties.Resources.Settings; }
        // Clicking opens a new frmSettings
        private void pbSettingsButton_Click(object sender, EventArgs e)
        {
            if (!WindowControl.settingsOpen) new frmSettings(this).Show();
            WindowControl.settingsOpen = true;
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
