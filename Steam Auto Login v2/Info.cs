using System.Diagnostics;
using System.Windows.Forms;

//Copyright © maksim789456 2018

namespace Steam_Auto_Login_v2
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/maksim789456/Steam-Auto-Login-v2");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://store.steampowered.com/legal/");
        }
    }
}
