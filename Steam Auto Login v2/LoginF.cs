using System;
using System.Windows.Forms;
using System.Diagnostics;

//Copyright © maksim789456 2018

namespace Steam_Auto_Login_v2
{
    public partial class LoginF : Form
    {
        string SteamPath = Properties.Settings.Default.SteamPath;
        string loginR = "";
        string passR = "";
        public LoginF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Process.Start(SteamPath," -tcp");
            }
            else

                Process.Start(SteamPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataR = "-login" + loginR + passR;
            if (checkBox1.Checked == true)
            {
                Process.Start(SteamPath, dataR + " -tcp");
            }
            else

           Process.Start(SteamPath, dataR);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginR = " " + textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passR = " " + textBox2.Text;
        }
    }
}
