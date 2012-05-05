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
using System.Runtime.InteropServices;
using System.IO;

namespace LightsOut
{
    public class Sys
    {
        /* Form Window Dragging */

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /* AppData Folder */

        public const string APPDATA_DIR_NAME = "Lights Out";

        public static string GetAppDataDir(string appName)
        {
            string appData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), appName);

            if (!Directory.Exists(appData))
                Directory.CreateDirectory(appData);

            return appData;
        }
    }

    public class WindowControl // Only allow one of any given window to be open at a time
    {
        public static bool aboutOpen = false;
        public static bool settingsOpen = false;
    }
}
