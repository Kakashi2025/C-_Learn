﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learn
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string? Notes { get; }

        private List<Transaction> _allTransactions = new List<Transaction>();


        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }

    }
}
