using System;
using System.Diagnostics;
using System.Windows.Forms;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            this.ShowInTaskbar = false;
            notifyIcon.Click += notifyIcon_Click;

            enterAccount_.Click += enterAccount_Click;
            selectSteamPath_.Click += selectSteamPath_Click;
            manualStart_.Click += manualStart_Click;
            manualStartTCP_.Click += manualStartTCP_Click;
            mExit_.Click += mExit_Click;

            Login.ReadLogin();
            Pass.ReadPass();

            //Acc1
            if (Properties.Settings.Default.AccOn1 == true)
            {
                if(Properties.Settings.Default.Name1 != "")
                {
                    acc1.Text = Properties.Settings.Default.Name1;
                }
                else
                {
                    acc1.Text = "1";
                }
            }
            else
                acc1.Text = "*DISABLE*";

            //Acc2
            if (Properties.Settings.Default.AccOn2 == true)
            {
                if (Properties.Settings.Default.Name2 != "")
                {
                    acc2.Text = Properties.Settings.Default.Name2;
                }
                else
                {
                    acc2.Text = "2";
                }
            }
            else
                acc2.Text = "*DISABLE*";

            //Acc3
            if (Properties.Settings.Default.AccOn3 == true)
            {
                if (Properties.Settings.Default.Name3 != "")
                {
                    acc3.Text = Properties.Settings.Default.Name3;
                }
                else
                {
                    acc3.Text = "3";
                }
            }
            else
                acc3.Text = "*DISABLE*";

            //Acc4
            if (Properties.Settings.Default.AccOn4 == true)
            {
                if (Properties.Settings.Default.Name4 != "")
                {
                    acc4.Text = Properties.Settings.Default.Name4;
                }
                else
                {
                    acc4.Text = "4";
                }
            }
            else
                acc4.Text = "*DISABLE*";
        }

        private void edit_data_Click(Object sender, EventArgs e)
        {
            //Не доделано
            //EditData f1 = new EditData();
            //f1.ShowDialog();
        }

        private void login_in_Click(object sender, EventArgs e)
        {
            LoginF f2 = new LoginF();
            f2.ShowDialog();
        }

        private void acc1_Click(object sender, EventArgs e)
        {
            string loginL = Program.Login.Login1;
            string passL = Program.Pass.Pass1;
            bool tcpON = checkBox1.Checked;
            Start.Starting(loginL,passL,tcpON);
        }

        private void acc2_Click(object sender, EventArgs e)
        {
            string loginL = Program.Login.Login2;
            string passL = Program.Pass.Pass2;
            bool tcpON = checkBox1.Checked;
            Start.Starting(loginL, passL, tcpON);
        }

        private void acc3_Click(object sender, EventArgs e)
        {
            string loginL = Program.Login.Login2;
            string passL = Program.Pass.Pass2;
            bool tcpON = checkBox1.Checked;
            Start.Starting(loginL, passL, tcpON);
        }

        private void acc4_Click(object sender, EventArgs e)
        {
            string loginL = Program.Login.Login2;
            string passL = Program.Pass.Pass2;
            bool tcpON = checkBox1.Checked;
            Start.Starting(loginL, passL, tcpON);
        }

        private void selectSteamPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogMain.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SteamPath = folderBrowserDialogMain.SelectedPath;
            }
        }

        private void enterAccount_Click(object sender, EventArgs e)
        {
            LoginF f2 = new LoginF();
            f2.ShowDialog();
        }

        private void manualStart_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.SteamPath);
        }

        private void manualStartTCP_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.SteamPath, "-tcp");
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoAboutProgramm_Click(object sender, EventArgs e)
        {
            Info f3 = new Info();
            f3.ShowDialog();
        }

        void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
