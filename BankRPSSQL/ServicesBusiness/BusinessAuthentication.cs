using BankRPSSQL.DataLayer;
using BankRPSSQL.Models;

namespace BankRPSSQL.ServicesBusiness
{
    public class BusinessAuthentication
    {
        IRepositoryAuthentication _irepauth = null;
        public BusinessAuthentication(IRepositoryAuthentication irepauth)
        {
            _irepauth = irepauth;
        }
        public BusinessAuthentication() : this(new Repository())
        { }
        public UserInfo GetUserInfo(string username)
        {
            return _irepauth.GetUserInfo(username);
        }

    }
}
