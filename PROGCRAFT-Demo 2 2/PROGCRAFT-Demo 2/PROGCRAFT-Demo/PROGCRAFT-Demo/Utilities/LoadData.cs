using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROGCRAFT_Demo.Utilities
{
    class LoadData
    {
        public static string LoadTextFromFile(string path)
        {
            return File.ReadAllText(path);
        }

        //public static string LoadTextFrimFile(string path) => File.ReadAllText(path);

        public static List<Item> LoadLinesFromFiles(string path)
        {
            //string output = "";

            //temp list of items
            List<Item> items = new List<Item>();

            foreach (string s in File.ReadAllLines(path))
            {
                //Utility.Print($"     * {s}");
                items.Add(new Item() { Name = s });
            }

            return items;
        }
    }
}
