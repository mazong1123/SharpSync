using System;

namespace SharpSync
{
    class Startup
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Options.PrintUsage();

                return;
            }
        }
    }
}