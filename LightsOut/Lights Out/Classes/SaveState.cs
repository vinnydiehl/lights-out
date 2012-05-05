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
using System.Windows.Forms;

namespace LightsOut
{
    public class SaveState
    {
        public static void Save(List<Panel> tiles, int clicks, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                writer.WriteLine(clicks.ToString());
                writer.WriteLine(Settings.gameMode);
                foreach (Panel tile in tiles)
                    writer.WriteLine(tile.BackColor == Settings.onColor ? "1" : "0");
            }
        }

        public static List<string> Load(string path)
        {
            List<string> saveState = new List<string>();

            if (!File.Exists(path)) return null;

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    saveState.Add(line);
            }

            return saveState;
        }
    }
}
