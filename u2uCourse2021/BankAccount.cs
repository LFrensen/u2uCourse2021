using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u2uCourse2021
{
    public class BankAccount
    {
        private decimal balance;

        public bool WithdrawMoney(decimal amount)
        {
            if(amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public bool DepositMoney(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }
    }
}
