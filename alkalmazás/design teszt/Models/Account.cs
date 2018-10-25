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
        private double ammount = 0;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public double Ammount
        {
            get { return ammount; }
            set { ammount = value; }
        }

        public Account(int accountId, int userId, string accountName, string currency, double ammount)
        {
            this.accountId = accountId;
            this.userId = userId;
            this.accountName = accountName;
            this.currency = currency;
            this.ammount = ammount;
        }
        public Account(int accountId, int userId, string accountName, string currency)
        {
            this.accountId = accountId;
            this.userId = userId;
            this.accountName = accountName;
            this.currency = currency;
        }
    }
}
