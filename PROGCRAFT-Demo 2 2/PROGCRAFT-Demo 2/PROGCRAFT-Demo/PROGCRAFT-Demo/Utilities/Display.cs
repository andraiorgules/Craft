﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGCRAFT_Demo.Utilities
{
    class Display
    {
        //delegate 
        public delegate void PrintPlatform(string message);

        public static PrintPlatform Print = PrintConsole;

        public static void PrintConsole(string message)
        {
            Console.WriteLine(message);
        }

        


    }
}
