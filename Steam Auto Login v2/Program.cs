using System;
using System.Windows.Forms;
using Microsoft.Win32;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.firstStart == false)
            {
                KeyG.KeyGenerator();
                Application.Run(new TFA_1());
            }
            else
            {
                KeyG.KeyRead();
                Application.Run(new TFA_Login());
            }
        }
        public class Login
        {
            public static string Login1 = "";
            public static string Login2 = "";
            public static string Login3 = "";
            public static string Login4 = "";
        }

        public class Pass
        {
            public static string Pass1 = "";
            public static string Pass2 = "";
            public static string Pass3 = "";
            public static string Pass4 = "";
        }

        public class KeyG
        {
            public static string key = "";

            public static void KeyGenerator()
            {
                Random rand = new Random();
                Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < 10; i++)
                    key += pwdChars[rand.Next(0, 35)];

                RegistryKey registryKey = Registry.CurrentUser;
                RegistryKey keyR = registryKey.CreateSubKey("Steam Auto Login");
                keyR.SetValue("key", key);
                keyR.Close();
            }

            public static void KeyRead()
            {
                RegistryKey registryKey = Registry.CurrentUser;
                RegistryKey keyR = registryKey.OpenSubKey("Steam Auto Login");
                key = keyR.GetValue("key").ToString();
            }
        }
    }
}
