using System.Data;

namespace BankRPSSQL.DataLayer
{
    public interface IEntity
    {
        void SetFields(DataRow dr);
    }
}
