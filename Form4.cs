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
    public partial class mainWindowSP : Form
    {
        public mainWindowSP()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainWindowSP_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText1))
            {
                button1.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText2))
            {
                button2.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText3))
            {
                button3.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText4))
            {
                button4.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText5))
            {
                button5.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText6))
            {
                button6.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText7))
            {
                button7.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText8))
            {
                button8.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText9))
            {
                button9.Hide();
            }
            if (String.IsNullOrEmpty(stealpredictor.confirmSig.finalText0))
            {
                button0.Hide();
            }
            button1.Text = "1. " + stealpredictor.confirmSig.finalText1;
            button2.Text = "2. " + stealpredictor.confirmSig.finalText2;
            button3.Text = "3. " + stealpredictor.confirmSig.finalText3;
            button4.Text = "4. " + stealpredictor.confirmSig.finalText4;
            button5.Text = "5. " + stealpredictor.confirmSig.finalText5;
            button6.Text = "6. " + stealpredictor.confirmSig.finalText6;
            button7.Text = "7. " + stealpredictor.confirmSig.finalText7;
            button8.Text = "8. " + stealpredictor.confirmSig.finalText8;
            button9.Text = "9. " + stealpredictor.confirmSig.finalText9;
            button0.Text = "0. " + stealpredictor.confirmSig.finalText0;
        }

        private void submitSigns_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(signsGiven.Text))
            {
                int arrSize = signsGiven.Text.Length-1;
                int[] array = new int[arrSize];
                if (Int32.TryParse(signsGiven.Text, out var temp) && arrSize > 1)
                {
                    allSigns.AppendText(signsGiven.Text + "-" + stealOrNo.Text + "\r\n");
                    for (int i = 0; i < arrSize; i++)
                    {
                        array[i] = Int32.Parse(signsGiven.Text.Substring(0,2));
                        signsGiven.Text = signsGiven.Text.Substring(1);
                    }
                    signsGiven.Text = "Array(of 2): " + string.Join("", array) + " Array Size: " + array.Length;
                    /*
                     TO DO:
                     1. Change array from signsGiven.Text to allSigns.Text
                     2. Make the program actually work
                     3. Make two steal and not steal arrays
                     4. Put steal signs and non steal signs in different arrays
                     */
                } else
                {
                    signsGiven.Text = "Input must be numbers.";
                    allSigns.AppendText("Invalid Input\r\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            signsGiven.Text = signsGiven.Text + "0";
        }

        private void steal_Click(object sender, EventArgs e)
        {
            stealOrNo.Text = "STEAL";
        }

        private void noSteal_Click(object sender, EventArgs e)
        {
            stealOrNo.Text = "NO STEAL";
        }
    }
}
