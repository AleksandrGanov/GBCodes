using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex317_WindowsFormsApp
{
    class Log
    {

        static public void LogConsole(string s, int x, int y)
        {
            Console.WriteLine($"Console {s} {x} {y}");
        }

        static public void LogFile(string s, int x, int y)
        {
            System.IO.File.AppendAllText("log.txt",$"{DateTime.Now} {s} {x} {y}\n");
        }
    }
}
