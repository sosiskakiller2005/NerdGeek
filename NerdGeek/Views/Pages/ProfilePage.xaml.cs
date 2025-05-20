using NerdGeek.AppData;
using NerdGeek.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NerdGeek.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        private User _selectedUser;
        private NerdGeekDbEntities _context = App.GetContext();
        public ProfilePage(User selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            UserGrid.DataContext = selectedUser;
            PasswordPb.Password = selectedUser.Password;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.selectedFrame.Navigate(new StartPage());
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailTb.Text) && !string.IsNullOrEmpty(PhoneTb.Text) && !string.IsNullOrEmpty(LoginTb.Text) && !string.IsNullOrEmpty(PasswordPb.Password))
            {
                _selectedUser.Email = EmailTb.Text;
                _selectedUser.Phone = PhoneTb.Text;
                _selectedUser.Login = LoginTb.Text;
                _selectedUser.Password = PasswordPb.Password;
                _context.SaveChanges();
                MessageBoxHelper.Information("Данные профиля успешно изменены");
                FrameHelper.selectedFrame.Navigate(new StartPage());
            }
            else
            {
                MessageBoxHelper.Error("Заполните все поля");
            }
        }
    }
}
