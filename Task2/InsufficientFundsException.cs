﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class InsufficientFundsException : Exception
    {
        public decimal CurrentBalance { get; }
        public decimal WithdrawAmount { get; }

        public InsufficientFundsException(string message, decimal currentBalance, decimal withdrawAmount) : base(message)
        {
            CurrentBalance = currentBalance;
            WithdrawAmount = withdrawAmount;
        }
        public override string ToString()
        {
            string message = $"{base.ToString()}\nCurrent Balance: {CurrentBalance:C}\nWithdraw Amount: {WithdrawAmount:C}";
            return message;
        }
    }
    public class InvalidDepositException : Exception
    {
        public decimal DepositAmount { get; }

        public InvalidDepositException(string message, decimal depositAmount) : base(message)
        {
            DepositAmount = depositAmount;
        }
        public override string ToString()
        {
            string message = $"{base.ToString()}\nInvalid Amount: {DepositAmount:C}";
            return message;
        }
    }
}
