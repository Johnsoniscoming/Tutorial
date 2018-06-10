using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAnd_Repay
{
    class person
    {
        public string Name;
        public int Money;

        public person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void borrow(person lender, int money)
        {
            if (lender.Money >= money)
            {
                lender.Money -= money;
                this.Money += money;
            }

        }

        public void repay(person lender , int money)
        {
            if (this.Money >= money)
            {
                this.Money -= money;
                lender.Money += money;
            }

        }
    }
}
