using BankRPSSQL.Models;
using BankRPSSQL.ServicesBusiness;
using BankRPSSQL.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankRPSSQL.Pages
{
    public class ShowBalancesModel : PageModel
    {
        IBusinessBanking _ibusbank = null;
        public ShowBalancesModel(IBusinessBanking ibusbank)
        {
            _ibusbank = ibusbank;
        }
        public decimal CheckingBalance { get; set; }
        public decimal SavingBalance { get; set; }
        public IActionResult OnGet()
        {
            if (SessionFacade.USERINFO == null) // not logged in
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            else
            {
                UserInfo uinfo = SessionFacade.USERINFO;
                CheckingBalance =
               _ibusbank.GetCheckingBalance(uinfo.CheckingAccountNumber);
                SavingBalance = _ibusbank.GetSavingBalance(uinfo.SavingAccountNumber);
            }
            return Page();
        }
    }
}
