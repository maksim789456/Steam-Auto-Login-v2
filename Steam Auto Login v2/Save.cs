//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    class Encryption
    {
        public static string Coding(string passwordC)
        {
            string key = "testtesttest";
            string all = @"`1234567890-=~!@#$%^&*()_+qwertyuiop[]QWERTYUIOP{}asdfghjkl;'\ASDFGHJKL:""|ZXCVBNM<>?zxcvbnm,./№ёЁйцукенгшщзхъЙЦУКЕНГШЩЗХЪфывапролджэФЫВАПРОЛДЖЭячсмитьбюЯЧСМИТЬБЮ";
            string st; int center;
            string leftSlice, rightSlice, cPass = "";

            if (key.Length > passwordC.Length)
            {
                key = key.Substring(0, passwordC.Length);
            }
            else
                for (int i = 0; key.Length < passwordC.Length; i++)
                {
                    key = key + key.Substring(i, 1);
                }
            for (int i = 0; i < passwordC.Length; i++)
            {
                center = all.IndexOf(key.Substring(i, 1));
                leftSlice = all.Substring(center);
                rightSlice = all.Substring(0, center);
                st = leftSlice + rightSlice;
                center = all.IndexOf(passwordC.Substring(i, 1));
                cPass += st.Substring(center, 1);
            }

            return cPass;
        }

        public static string Uncoding(string passwordD)
        {
            string key = "testtesttest";
            string all = @"`1234567890-=~!@#$%^&*()_+qwertyuiop[]QWERTYUIOP{}asdfghjkl;'\ASDFGHJKL:""|ZXCVBNM<>?zxcvbnm,./№ёЁйцукенгшщзхъЙЦУКЕНГШЩЗХЪфывапролджэФЫВАПРОЛДЖЭячсмитьбюЯЧСМИТЬБЮ";
            string st; int center;
            string leftSlice, rightSlice, cPass = "";


            if (key.Length > passwordD.Length)
            {
                key = key.Substring(0, passwordD.Length);
            }

            else
                for (int i = 0; key.Length < passwordD.Length; i++)
                {
                    key = key + key.Substring(i, 1);
                }

            for (int i = 0; i < passwordD.Length; i++)
            {

                center = all.IndexOf(key.Substring(i, 1));
                leftSlice = all.Substring(center);
                rightSlice = all.Substring(0, center);
                st = leftSlice + rightSlice;
                center = st.IndexOf(passwordD.Substring(i, 1));
                cPass += all.Substring(center, 1);
            }
            return cPass;
        }
    }

    class Login
    {
        public static void SaveLogin()
        {
            Properties.Settings.Default.Login1 = Program.Login.Login1;
            Properties.Settings.Default.Login2 = Program.Login.Login2;
            Properties.Settings.Default.Login3 = Program.Login.Login3;
            Properties.Settings.Default.Login4 = Program.Login.Login4;
            Properties.Settings.Default.Save();
        }

        public static void ReadLogin()
        {
            Program.Login.Login1 = Properties.Settings.Default.Login1;
            Program.Login.Login2 = Properties.Settings.Default.Login2;
            Program.Login.Login3 = Properties.Settings.Default.Login3;
            Program.Login.Login4 = Properties.Settings.Default.Login4;
        }
    }

    class Pass
    {
        public static void SavePass()
        {
            string passsword1 = Program.Pass.Pass1;
            string passsword2 = Program.Pass.Pass2;
            string passsword3 = Program.Pass.Pass3;
            string passsword4 = Program.Pass.Pass4;
            string passwordC = "";
            //pass1
            if (Properties.Settings.Default.AccOn1 == true)
            {
                passwordC = passsword1;
                Properties.Settings.Default.Pass1 = Encryption.Coding(passwordC);
                passwordC = "";
            }
            //pass2
            if (Properties.Settings.Default.AccOn2 == true)
            {
                passwordC = passsword2;
                Properties.Settings.Default.Pass2 = Encryption.Coding(passwordC);
                passwordC = "";
            }
            //pass3
            if (Properties.Settings.Default.AccOn3 == true)
            {
                passwordC = passsword3;
                Properties.Settings.Default.Pass3 = Encryption.Coding(passwordC);
                passwordC = "";
            }
            //pass4
            if (Properties.Settings.Default.AccOn4 == true)
            {
                passwordC = passsword4;
                Properties.Settings.Default.Pass4 = Encryption.Coding(passwordC);
                passwordC = "";
            }
        }

        public static void ReadPass()
        {
            string password1 = Properties.Settings.Default.Pass1;
            string password2 = Properties.Settings.Default.Pass2;
            string password3 = Properties.Settings.Default.Pass3;
            string password4 = Properties.Settings.Default.Pass4;
            string passwordD = "";
            //pass1
            if (Properties.Settings.Default.AccOn1 == true)
            {
                passwordD = password1;
                Program.Pass.Pass1 = Encryption.Uncoding(passwordD);
                passwordD = "";
            }
            //pass2
            if (Properties.Settings.Default.AccOn2 == true)
            {
                passwordD = password2;
                Program.Pass.Pass2 = Encryption.Uncoding(passwordD);
                passwordD = "";
            }
            //pass3
            if (Properties.Settings.Default.AccOn3 == true)
            {
                passwordD = password3;
                Program.Pass.Pass3 = Encryption.Uncoding(passwordD);
                passwordD = "";
            }
            //pass4
            if (Properties.Settings.Default.AccOn4 == true)
            {
                passwordD = password4;
                Program.Pass.Pass4 = Encryption.Uncoding(passwordD);
                passwordD = "";
            }
        }
    }
}
