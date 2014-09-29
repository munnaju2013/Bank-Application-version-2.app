using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.app
{
    public partial class BankUI : Form
    {
        public BankUI()
        {
            InitializeComponent();
        }

        private Account anAccount;
        private double amount;

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();
            anAccount.number = accountNumberTextBox.Text;
            anAccount.name = customerNameTextBox.Text;
            MessageBox.Show(@"Account has been been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Deposit(amount);
                MessageBox.Show(@"Account has been deposited....");
                amountTextBox.Text=String.Empty;

            }
            else
            {
                MessageBox.Show(@"Please create a new account...");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            anAccount.Withdraw(amount);
            MessageBox.Show(@"Amount has been withdrawn......");
            amountTextBox.Text = String.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.GetReport());
        }

    }
}
