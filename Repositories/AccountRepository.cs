using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public void CreateAccount(AccountMember account) => AccountMemberDAO.CreateAccount(account);

        public List<AccountMember> GetAccounts() => AccountMemberDAO.GetAccounts();

        public void UpdateAccount(AccountMember account) => AccountMemberDAO.UpdateAccount(account);

        public AccountMember GetAccountsByID(int id) => AccountMemberDAO.GetAccountByID(id);
    }
}
