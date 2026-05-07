using BusinessObjects;
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
    /// Interaction logic for AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window
    {
        private readonly CourseManagementDbContext _context;
        public AccountMember account { get; private set; }

        public AddAccount()
        {
            InitializeComponent();
            _context = new CourseManagementDbContext();
            LoadRole();
        }

        public void LoadRole()
        {
            var listRole = new List<string>
            {
                "Admin",
                "Staff"
            };
            cboRole.ItemsSource = listRole;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to add this user?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                account = new AccountMember
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = cboRole.SelectedIndex,
                    Status = 1
                };
                DialogResult = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
