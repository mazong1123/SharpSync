using System;
using System.Collections.Generic;
using System.Text;

namespace SharpSync
{
    public class Options
    {
        public static void PrintVersion()
        {
        }
        public static void PrintUsage()
        {
            PrintVersion();

            Console.WriteLine();
            Console.WriteLine("SharpSync is a cross-platform file transfer program inspired by rsync.");
            Console.WriteLine();
        }
    }
}
