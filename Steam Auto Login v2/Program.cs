using System;
using System.Windows.Forms;

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
                Application.Run(new TFA_1());
            }
            else
            {
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

        public class Key
        {
            public static string key = "";
        }
    }
}
