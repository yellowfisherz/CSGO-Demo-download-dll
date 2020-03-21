using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace libShareCodeToURL
{
    class Downloadserver
    {
        public static int StartBoiler(string args = "")
        {
            Process[] currentProcess = Process.GetProcessesByName("csgo");
            if (currentProcess.Length > 0) return 123;

            Process boiler = new Process
            {
                StartInfo =
                {
                    FileName = "boiler.exe",
                    Arguments = $"\"{"matches.dat"}\" {args}",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            boiler.Start();
            boiler.WaitForExit(90000);
            try
            {
                int errorcode = boiler.ExitCode;
                return errorcode;
            }
            catch
            {
                return 100;
            }
        }
    }
}
