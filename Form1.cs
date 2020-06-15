using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stealpredictor
{
    public partial class variableSetWindow : Form
    {
        public static string passText1;
        public static string passText2;
        public static string passText3;
        public static string passText4;
        public static string passText5;
        public static string passText6;
        public static string passText7;
        public static string passText8;
        public static string passText9;
        public static string passText0;
        public variableSetWindow()
        {
            InitializeComponent();
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            creditsWindow creditsWindow = new creditsWindow();
            creditsWindow.Show();
        }

        private void dllink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://to.aidanb.xyz/?bbsp&referral=bbsp");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            creditsButton.Hide();
            bsp.Hide();
            startButton.Hide();
            submit.Show();
            varDefineText.Show();
            label1.Show();
            option1.Show();
            label2.Show();
            option2.Show();
            label3.Show();
            option3.Show();
            label4.Show();
            option4.Show();
            label5.Show();
            option5.Show();
            label6.Show();
            option6.Show();
            label7.Show();
            option7.Show();
            label8.Show();
            option8.Show();
            label9.Show();
            option9.Show();
            label10.Show();
            option0.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            passText1 = option1.Text;
            passText2 = option2.Text;
            passText3 = option3.Text;
            passText4 = option4.Text;
            passText5 = option5.Text;
            passText6 = option6.Text;
            passText7 = option7.Text;
            passText8 = option8.Text;
            passText9 = option9.Text;
            passText0 = option0.Text;
            confirmSig form3 = new confirmSig();
            form3.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
