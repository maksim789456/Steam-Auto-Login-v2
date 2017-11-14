using System;
using System.Diagnostics;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    class Start
    {
        public static void Starting(string loginL, string passL,bool tcpON)
        {
            string SteamPath = Properties.Settings.Default.SteamPath;
            string DataL = "-login" + " " + loginL + " " + passL;
            if (tcpON == true)
            {
                Process.Start(SteamPath, DataL + " -tcp");
            }
            else
                Process.Start(SteamPath, DataL);
        }
    }
}
