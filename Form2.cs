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
    public partial class creditsWindow : Form
    {
        public creditsWindow()
        {
            InitializeComponent();
        }

        private void clink1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://jabrils.com/sp/");
        }

        private void clink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dafont.com/veteran-typewriter.font");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
