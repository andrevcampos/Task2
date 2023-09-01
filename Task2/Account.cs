using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [Serializable]
    public abstract class Account
    {
        static int nextAccountID = 1;
        private int AccountID;
        private int balance;

        public Account(int newBalance)
        {
            AccountID = nextAccountID;
            nextAccountID++;
            balance = newBalance;
        }
        public int GetAccountID
        {
            get { return AccountID; }
            set { AccountID = value; }
        }
        public int GetBalance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new InvalidDepositException("Invalid amount.", amount);
            }
            balance += amount;
            Console.WriteLine($"Successfully deposit {amount:C}. Current Balance: {balance:C}");
        }
        public void Withdrawal(int amount)
        {
            if (amount > balance)
            {
                string errorMessage = "";

                if (this is Everyday)
                {
                    errorMessage = "Everyday Account - Insufficient fund to withdraw.";
                }
                else if (this is Inverstiment)
                {
                    errorMessage = "Inverstiment Account - Insufficient fund to withdraw.";
                }
                else if (this is Omni)
                {
                    errorMessage = "Omni Account - Insufficient fund to withdraw.";
                }

                throw new InsufficientFundsException(errorMessage, balance, amount);
            }

            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount:C}. Current Balance: {balance:C}");
        }

        public virtual int Balance()
        {
            return balance;
        }
        public abstract int GetFees();
        public abstract int GetInterest();
        public abstract string GetInterestrandom();
        public abstract int GetOverdraft();

        public virtual string Info()
        {
            return "(ID:" + AccountID.ToString() + ")";
        }

        public virtual string ToString()
        {
            return "(ID:" + AccountID.ToString() + ")";
        }
    }
    [Serializable]
    public class Everyday : Account
    {
        //fee is not applied
        //overdraft is not allowed
        //interest is not applied
        public Everyday(int newbalance) : base(newbalance)
        {
        }
        public override string Info()
        {
            return base.ToString() + " Everyday Account";
        }
        public override string ToString()
        {
            return base.ToString() + " Everyday Account; Balance: " + base.Balance();
        }
        public override int GetFees() { return 0; }
        public override int GetInterest() { return 0; }
        public override string GetInterestrandom() { return "n/a"; }
        public override int GetOverdraft() { return 0; }


    }
    [Serializable]
    public class Inverstiment : Account
    {
        private int interestmin = 10;
        private int interestmax = 20;
        private int fees;

        public Inverstiment(int newFee, int newbalance) : base(newbalance)
        {
            fees = newFee;
        }
        public override int GetFees()
        {
            return fees;
        }
        public override int GetInterest()
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(interestmin, interestmax);
            return randomnumber;
        }
        public override int GetOverdraft() { return 0; }
        public override string GetInterestrandom()
        {
            return "(Varied) " + interestmin.ToString() + "% - " + interestmax.ToString() + "%";
        }
        public override string Info()
        {
            return base.ToString() + " Inverstiment Account";
        }
        public override string ToString()
        {
            return base.ToString() + "Inverstiment Account, Interest Rate:" + GetInterest() + "; Fee: $" + fees + "; Balance: " + base.Balance();
        }
    }
    [Serializable]
    public class Omni : Account
    {
        private int interest;
        private int overdraft;
        private int fees;
        public Omni(int newFee, int newInterest, int newOverdraft, int newbalance) : base(newbalance)
        {
            fees = newFee;
            interest = newInterest;
            overdraft = newOverdraft;
        }
        public override int GetFees()
        {
            return fees;
        }
        public override int GetInterest()
        {
            return interest;
        }
        public override int GetOverdraft()
        {
            return overdraft;
        }
        public override string GetInterestrandom() { return "n/a"; }
        public override string Info()
        {
            return base.ToString() + " Omni Account";
        }
        public override string ToString()
        {
            return base.ToString() + " Omni Account, Interest Rate: " + interest + "%; Overdraft Limit: $" + overdraft + "; Fee: $" + fees + "; Balance: " + base.Balance();
        }
    }
}
