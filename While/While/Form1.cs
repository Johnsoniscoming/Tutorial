using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            //int i = 1;
            //while (i <= 9)
            //{
            //    text += "8 x " + i + " = " + 8 * i + "\r\n";
            //    i++;
            //}
            for(int i = 1; i <= 9; i++)
            {
                text += "8 x " + i + " = " + 8 * i + "\r\n";
            }
            MessageBox.Show(text);
        }
    }
}
