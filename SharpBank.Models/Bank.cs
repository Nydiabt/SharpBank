﻿using SharpBank.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBank.Models
{
    public class Bank
    {
        public long BankId { get; set; }
        public string Name { get; set; }

        public string Logo { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }


        public decimal IMPS { get; set; }
        public decimal RTGS { get; set; }
        public decimal NEFT { get; set; }


        public decimal GetRate(TransactionType transactionType) => transactionType switch
        {
            TransactionType.RTGS => 2m,
            TransactionType.IMPS => 5m,
            _ => 0m
        };

        public ICollection<Account> Accounts { get; set; }

    }
}
