using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IAccountSevice
    {
        public void CreateAccount(AccountMember account);
        public void UpdateAccount(AccountMember account);
        public List<AccountMember> GetAccounts();
        public AccountMember GetAccountsByID(int id);
    }
}
