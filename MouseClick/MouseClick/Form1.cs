using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++;
            lblTimes.Text = "You already click ... " + times + " times";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;
            lblTimes.Text = "You already click ..." + times + " times";
        }
    }
}
