using System;
using System.Windows.Forms;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    public partial class FirstStart : Form
    {
        public FirstStart()
        {
            InitializeComponent();
        }

        private void textBox_Login1_TextChanged(object sender, EventArgs e)
        {
            Program.Login.Login1 = textBox_Login1.Text;
        }

        private void textBox_Login2_TextChanged(object sender, EventArgs e)
        {
            Program.Login.Login2 = textBox_Login2.Text;
        }

        private void textBox_Login3_TextChanged(object sender, EventArgs e)
        {
            Program.Login.Login3 = textBox_Login3.Text;
        }

        private void textBox_Login4_TextChanged(object sender, EventArgs e)
        {
            Program.Login.Login4 = textBox_Login4.Text;
        }

        private void textBox_Pass1_TextChanged(object sender, EventArgs e)
        {
            Program.Pass.Pass1 = textBox_Pass1.Text;
        }

        private void textBox_Pass2_TextChanged(object sender, EventArgs e)
        {
            Program.Pass.Pass2 = textBox_Pass2.Text;
        }

        private void textBox_Pass3_TextChanged(object sender, EventArgs e)
        {
            Program.Pass.Pass3 = textBox_Pass3.Text;
        }

        private void textBox_Pass4_TextChanged(object sender, EventArgs e)
        {
            Program.Pass.Pass4 = textBox_Pass4.Text;
        }

        private void textBox_Name1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name1 = textBox_Name1.Text;
        }

        private void textBox_Name2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name2 = textBox_Name2.Text;
        }

        private void textBox_Name3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name3 = textBox_Name3.Text;
        }

        private void textBox_Name4_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Name4 = textBox_Name4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Acc1
            if (checkBox_acc1.Checked)
            {
                Properties.Settings.Default.AccOn1 = true;
                Properties.Settings.Default.Name1 = textBox_Name1.Text;
            }
            else
                Properties.Settings.Default.AccOn1 = false;
            //Acc2
            if (checkBox_acc2.Checked)
            {
                Properties.Settings.Default.AccOn2 = true;
                Properties.Settings.Default.Name2 = textBox_Name1.Text;
            }
            else
                Properties.Settings.Default.AccOn2 = false;
            //Acc3
            if (checkBox_acc3.Checked)
            {
                Properties.Settings.Default.AccOn3 = true;
                Properties.Settings.Default.Name3 = textBox_Name1.Text;
            }
            else
                Properties.Settings.Default.AccOn3 = false;
            //Acc4
            if (checkBox_acc4.Checked)
            {
                Properties.Settings.Default.AccOn4 = true;
                Properties.Settings.Default.Name4 = textBox_Name1.Text;
            }
            else
                Properties.Settings.Default.AccOn4 = false;
            Properties.Settings.Default.firstStart = true;
            Login.SaveLogin();
            Pass.SavePass();
            Properties.Settings.Default.Save();
            //Закрываемcя и запускаем Main
            Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void textBox_SteamPath_TextChanged(object sender, EventArgs e)
        {
            textBox_SteamPath.Text = folderBrowserDialogFirstStart.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogFirstStart.ShowDialog() == DialogResult.OK)
            {
                textBox_SteamPath.Text = folderBrowserDialogFirstStart.SelectedPath;
                Properties.Settings.Default.SteamPath = textBox_SteamPath.Text;
            }
        }
    }
}
