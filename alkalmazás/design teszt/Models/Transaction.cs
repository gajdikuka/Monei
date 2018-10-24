using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Models
{
    class Transaction
    {
        private int transactionId, accountId, userId;
        private string transactionName, userNote;
        private double crediting;

        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string TransactionName { get; set; }
        public string UserNote { get; set; }
        public double Crediting { get; set; }
    }
}
