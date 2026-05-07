using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountMemberDAO
    {
        public static AccountMember CheckExist(string username, string password)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            AccountMember accountMember = _context.AccountMembers.FirstOrDefault(u => u.Username == username && u.Password == password);
            return accountMember;
        }
        public static void CreateAccount(AccountMember accountMember)
        {
            using (CourseManagementDbContext _context = new CourseManagementDbContext())
            {
                _context.AccountMembers.Add(accountMember);
                _context.SaveChanges();
            }
        }

        public static List<AccountMember> GetAccounts()
        {
            using (CourseManagementDbContext _context = new CourseManagementDbContext())
            {
                return _context.AccountMembers.ToList();
            }
        }

        public static void UpdateAccount(AccountMember accountMember)
        {
            using (CourseManagementDbContext _context = new CourseManagementDbContext())
            {
                _context.AccountMembers.Update(accountMember);
                _context.SaveChanges();
            }
        }

        public static AccountMember GetAccountByID(int id)
        {
            using (CourseManagementDbContext _context = new CourseManagementDbContext())
            {
                return _context.AccountMembers.FirstOrDefault(u => u.AccountId == id);
            }
        }
    }
}
