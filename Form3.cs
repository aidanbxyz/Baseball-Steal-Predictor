using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stealpredictor
{
    public partial class confirmSig : Form
    {
        public static string finalText1;
        public static string finalText2;
        public static string finalText3;
        public static string finalText4;
        public static string finalText5;
        public static string finalText6;
        public static string finalText7;
        public static string finalText8;
        public static string finalText9;
        public static string finalText0;
        public confirmSig()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            text1.Text = stealpredictor.variableSetWindow.passText1;
            text2.Text = stealpredictor.variableSetWindow.passText2;
            text3.Text = stealpredictor.variableSetWindow.passText3;
            text4.Text = stealpredictor.variableSetWindow.passText4;
            text5.Text = stealpredictor.variableSetWindow.passText5;
            text6.Text = stealpredictor.variableSetWindow.passText6;
            text7.Text = stealpredictor.variableSetWindow.passText7;
            text8.Text = stealpredictor.variableSetWindow.passText8;
            text9.Text = stealpredictor.variableSetWindow.passText9;
            text0.Text = stealpredictor.variableSetWindow.passText0;
            if (String.IsNullOrEmpty(text1.Text))
            {
                text1.Text = "Have at least two signs.";
            }
            if (String.IsNullOrEmpty(text2.Text))
            {
                text2.Text = "Have at least two signs.";
            }
            if (String.IsNullOrEmpty(text3.Text))
            {
                text3.Hide();
                label3.Hide();
            }
            if (String.IsNullOrEmpty(text4.Text))
            {
                text4.Hide();
                label4.Hide();
            }
            if (String.IsNullOrEmpty(text5.Text))
            {
                text5.Hide();
                label5.Hide();
            }
            if (String.IsNullOrEmpty(text6.Text))
            {
                text6.Hide();
                label6.Hide();
            }
            if (String.IsNullOrEmpty(text7.Text))
            {
                text7.Hide();
                label7.Hide();
            }
            if (String.IsNullOrEmpty(text8.Text))
            {
                text8.Hide();
                label8.Hide();
            }
            if (String.IsNullOrEmpty(text9.Text))
            {
                text9.Hide();
                label9.Hide();
            }
            if (String.IsNullOrEmpty(text0.Text))
            {
                text0.Hide();
                label10.Hide();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            finalText1 = text1.Text;
            finalText2 = text2.Text;
            finalText3 = text3.Text;
            finalText4 = text4.Text;
            finalText5 = text5.Text;
            finalText6 = text6.Text;
            finalText7 = text7.Text;
            finalText8 = text8.Text;
            finalText9 = text9.Text;
            finalText0 = text0.Text;
            mainWindowSP form4 = new mainWindowSP();
            form4.Show();
            this.Hide();
        }
    }
}
