using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei_project.Models
{
    class Transaction
    {
        private int transactionId, accountId, userId;
        private string transactionName, userNote;
        private double crediting;

        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }
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
        public string TransactionName
        {
            get { return transactionName; }
            set { transactionName = value; }
        }
        public string UserNote
        {
            get { return userNote; }
            set { userNote = value; }
        }
        public double Crediting
        {
            get { return crediting; }
            set { crediting = value; }
        }

        public Transaction(int transactionId, int accountId, int userId, string transactionName, string userNote, double crediting)
        {
            this.transactionId = transactionId;
            this.accountId = accountId;
            this.userId = userId;
            this.transactionName = transactionName;
            this.userNote = userNote;
            this.crediting = crediting;
        }
        public Transaction(int transactionId, int accountId, int userId, string transactionName, double crediting)
        {
            this.transactionId = transactionId;
            this.accountId = accountId;
            this.userId = userId;
            this.transactionName = transactionName;
            this.crediting = crediting;
        }
    }
}
