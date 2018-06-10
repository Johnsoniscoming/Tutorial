using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAnd_Repay
{
    public partial class Form1 : Form
    {
        person i, other;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            i.borrow(other, 1000);
            updateMoney();
        }

        private void btnRepay_Click(object sender, EventArgs e)
        {
            i.repay(other, 1000);
            updateMoney();
        }

        private void updateMoney()
        {
            lblmyMoney.Text =""+ i.Money;
            lblotherMoney.Text = ""+other.Money;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            i = new person(myNameInput.Text, 0);
            other = new person(otherNameInput.Text, 200000);
            myNameInput.Enabled = false;
            otherNameInput.Enabled = false;
            btnConfirm.Enabled = false;
            btnBorrow.Text = "Borrow from " + other.Name;
            btnRepay.Text = "Repay to " + other.Name;
            btnBorrow.Enabled = true;
            btnRepay.Enabled = true;
            lblMy.Text = i.Name;
            lblOther.Text = other.Name;
        }
    }
}
