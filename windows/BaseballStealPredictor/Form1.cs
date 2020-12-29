using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseballStealPredictor
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static List<string> mainarray = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '9';
        }

        private void button0_Click(object sender, EventArgs e)
        {
            maintextbox.Text += '0';
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            maintextbox.Text = maintextbox.Text.Remove(maintextbox.Text.Length - 1);
        }

        private void maintextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Contains("1"))
            {
                maintextbox.Text += '1';
            }
            if (e.KeyCode.ToString().Contains("2"))
            {
                maintextbox.Text += '2';
            }
            if (e.KeyCode.ToString().Contains("3"))
            {
                maintextbox.Text += '3';
            }
            if (e.KeyCode.ToString().Contains("4"))
            {
                maintextbox.Text += '4';
            }
            if (e.KeyCode.ToString().Contains("5"))
            {
                maintextbox.Text += '5';
            }
            if (e.KeyCode.ToString().Contains("6"))
            {
                maintextbox.Text += '6';
            }
            if (e.KeyCode.ToString().Contains("7"))
            {
                maintextbox.Text += '7';
            }
            if (e.KeyCode.ToString().Contains("8"))
            {
                maintextbox.Text += '8';
            }
            if (e.KeyCode.ToString().Contains("9"))
            {
                maintextbox.Text += '9';
            }
            if (e.KeyCode.ToString().Contains("0"))
            {
                maintextbox.Text += '0';
            }
            if (e.KeyCode.ToString() == "Back")
            {
                maintextbox.Text = maintextbox.Text.Remove(maintextbox.Text.Length - 1);
            }
        }

        public string listToString(List<string> theList)
        {
            return string.Join(",", theList.ToArray());
        }
    }
}
