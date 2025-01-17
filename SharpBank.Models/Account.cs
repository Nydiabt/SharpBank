﻿using SharpBank.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money;

namespace SharpBank.Models
{
    public class Account
    {
        public long AccountId { get; set; }
        public string Name { get; set; }
        public long BankId { get; set; }
        public string Password { get; set; }
        public Funds Balance { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
