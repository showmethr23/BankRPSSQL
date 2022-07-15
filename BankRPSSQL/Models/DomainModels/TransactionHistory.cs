using System;

namespace BankRPSSQL.Models.DomainModels
{
    public class TransactionHistory
    {
        public long TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long CheckingAccountNumber { get; set; }
        public long SavingAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal TransactionFee { get; set; }
        public int TransactionTypeId { get; set; }
    }
}
