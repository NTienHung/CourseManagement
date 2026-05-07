using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountSevice : IAccountSevice
    {
        private readonly IAccountRepository _irepository;

        public AccountSevice()
        {
            _irepository = new AccountRepository();
        }
        public void CreateAccount(AccountMember account)
        {
            _irepository.CreateAccount(account);
        }

        public List<AccountMember> GetAccounts()
        {
            return _irepository.GetAccounts();
        }

        public AccountMember GetAccountsByID(int id)
        {
            return _irepository.GetAccountsByID(id);
        }

        public void UpdateAccount(AccountMember account)
        {
            _irepository.UpdateAccount(account);
        }
    }
}
