using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Invalid value for ID!");
                    return;
                }
                else
                {
                    id = value;
                }
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid value for balance!");
                    return;
                }
                else
                {
                    balance = value;
                }
            }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account : {this.id}, balance : {this.balance}";
        }
    }
}
