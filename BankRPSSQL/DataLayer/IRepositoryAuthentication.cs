using BankRPSSQL.Models;

namespace BankRPSSQL.DataLayer
{
    public interface IRepositoryAuthentication
    {
        UserInfo GetUserInfo(string username);

    }
}
