using BankRPSSQL.Models.DomainModels;
namespace BankRPSSQL.Models.ViewModels
{
    public class TransactionHistoryVM : TransactionHistory
    {
        public string TransactionTypeName { get; set; } // added field
    }
}
