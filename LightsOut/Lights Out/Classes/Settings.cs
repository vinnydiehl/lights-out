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
using System.IO;
using System.Text;
using System.Drawing;

namespace LightsOut
{
    public class Settings
    {
        public const string SETTINGS_FILE = "LightsOutSettings.cfg";

        public static bool newGameOnStart = false;
        public static bool newGameOnCompletion = false;
        public static bool resetClicksOnNewGame = true;
        public static bool lightsOnMode = false;
        public static bool onlyLit = false;
        public static string gameMode = "R";
        public static Color offColor = Color.DarkGreen;
        public static Color onColor = Color.Lime;
        public static Color previousOffColor = Color.DarkGreen;

        public static void colorShift() // Sets previousOffColor
        {
            previousOffColor = offColor;
        }
    }
    public class Defaults
    {
        public static bool newGameOnStart = false;
        public static bool newGameOnCompletion = false;
        public static bool resetClicksOnNewGame = true;
        public static bool lightsOnMode = false;
        public static bool onlyLit = false;
        public static string gameMode = "R";
        public static Color offColor = Color.DarkGreen;
        public static Color onColor = Color.Lime;
    }

    public class SettingsReader
    {
        private Dictionary<string, string> settings;

        public SettingsReader(string appName, string fileName) // Constructor
        {
            settings = new Dictionary<string, string>();

            string path = Path.Combine(Sys.GetAppDataDir(appName), fileName);

            if (!File.Exists(path)) return;

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line, name, val;
                int pos;

                while ((line = sr.ReadLine()) != null)
                {
                    pos = line.IndexOf('=');
                    if (pos != -1)
                    {
                        name = line.Substring(0, pos);
                        val = line.Substring(pos + 1);

                        if (!settings.ContainsKey(name))
                            settings.Add(name, val);
                    }
                }
            }
        }

        public string Load(string name)
        {
            return settings.ContainsKey(name) ? settings[name] : null;
        }
    }

    public class SettingsWriter
    {
        private StreamWriter writer;

        public SettingsWriter(string appName, string fileName) // Constructor
        {
            writer = new StreamWriter(Path.Combine(Sys.GetAppDataDir(Sys.APPDATA_DIR_NAME), fileName), false, Encoding.UTF8);
        }

        public void Save(string name, string value)
        {
            writer.WriteLine(name + "=" + value);
        }

        public void Close()
        {
            writer.Close();
        }
    }
}
