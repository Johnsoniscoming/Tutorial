using classDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s=new Student(101,"Mary");
            MessageBox.Show(s.Say());
            s.Upgrade();
            MessageBox.Show(s.Say());
            Student s2 = new Student(100,"John");
            MessageBox.Show(s2.Talk(s2));
        }


    }
}
