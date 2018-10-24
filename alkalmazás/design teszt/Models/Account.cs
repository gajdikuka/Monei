using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Models
{
    class Account
    {
        private int accountId, userId;
        private string accountName, currency;
        private double ammount;

        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string AccountName { get; set; }
        public string Currency { get; set; }
        public double Ammount { get; set; }
    }
}
