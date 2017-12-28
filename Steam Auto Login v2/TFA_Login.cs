using System;
using Google.Authenticator;
using System.Windows.Forms;

//Copyright © maksim789456  2017

namespace Steam_Auto_Login_v2
{
    public partial class TFA_Login : Form
    {
        public int i;
        public TFA_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "1";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "2";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "3";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "4";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "5";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "6";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "7";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "8";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i < 6)
            {
                i++;
                textBox.Text = textBox.Text + "9";
            }
            else
                MessageBox.Show("Код 6-ый значный,остановись");
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            i++;
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            bool corrctPin = tfa.ValidateTwoFactorPIN(Program.KeyG.key, textBox.Text);

            if (corrctPin == true)
            {
                Hide();
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный код");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox.Text = "";
        }
    }
}
