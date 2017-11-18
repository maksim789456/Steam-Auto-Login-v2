using System;
using System.Diagnostics;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    class Start
    {
        public static void Starting(string loginL, string passL, bool tcpON)
        {
            Stoping();
            string DataL = "-login" + " " + loginL + " " + passL;
            if (tcpON == true)
            {
                Process procTcp = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Properties.Settings.Default.SteamPath,
                        Arguments = DataL + " -tcp",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                procTcp.Start();
            }
            else
            {
                Process proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Properties.Settings.Default.SteamPath,
                        Arguments = DataL,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
            }
        }
        
        public static void Stoping()
        {
            Process.Start("taskkill", "/F /IM GameOverlayUI.exe");
            Process.Start("taskkill", "/F /IM Steam.exe");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
