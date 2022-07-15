using BankRPSSQL.Models;

namespace BankRPSSQL.ServicesBusiness
{
    public interface IBusinessAuthentication
    {
        UserInfo GetUserInfo(string username);
    }
}
