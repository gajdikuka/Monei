using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class Account
    {
        private string accountName, currency, username;
        private double ammount = 0;
        public string Username
        {
            get { return username; }
            set { username = value; }
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

        public Account(string username, string accountName, string currency, double ammount)
        {
            Username = username;
            AccountName = accountName;
            Currency = currency;
            Ammount = ammount;
        }
        public Account(string username, string accountName, string currency)
        {
            Username = username;
            AccountName = accountName; 
            Currency = currency;        }
    }
}
