using BankRPSSQL.Models;
using BankRPSSQL.Models.ViewModels;
using BankRPSSQL.ServicesBusiness;
using BankRPSSQL.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace BankRPSSQL.Pages
{
    public class TransactionHistoryModel : PageModel
    {
        IBusinessBanking _ibusbank = null;
        public TransactionHistoryModel(IBusinessBanking ibusbank)
        {
            _ibusbank = ibusbank;
        }
        public List<TransactionHistoryVM> TList { get; set; }
        public IActionResult OnGet()
        {
            if (SessionFacade.USERINFO == null) // not logged in
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            else
            {
                UserInfo uinfo = SessionFacade.USERINFO;
                TList = _ibusbank.GetTransactionHistory(uinfo.CheckingAccountNumber);
            }
            return Page();
        }

    }
}
