using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank.app
{
    class Account
    {
        public string number;
        public string name;
        public double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;

        }

        public string GetReport()
        {
            string msg = name + " your account no is " + number + " and balance is " + balance;
            return msg;
        }
           
    }
}
