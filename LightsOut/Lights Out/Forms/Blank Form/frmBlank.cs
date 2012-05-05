using System;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class frmBlank : Form
    {
        public frmBlank()
        {
            InitializeComponent(); // Load GUI
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
