using BusinessObjects;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseManagementSystem.AccountManagement
{
    /// <summary>
    /// Interaction logic for AccountManagement.xaml
    /// </summary>
    public partial class AccountManagement : Window
    {
        private readonly IAccountSevice accountSevice;
        private readonly CourseManagementDbContext _context;
        public AccountManagement()
        {
            InitializeComponent();
            accountSevice = new AccountSevice();
            _context = new CourseManagementDbContext();
            LoadStudent();
        }

        public void LoadStudent()
        {
            dgSemester.ItemsSource = accountSevice.GetAccounts();
        }

        private void dgSemester_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddAccount();
            if (dialog.ShowDialog() == true)
            {
                accountSevice.CreateAccount(dialog.account);
                MessageBox.Show("User added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadStudent();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
