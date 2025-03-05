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
using System.Windows.Shapes;

namespace NerdGeek.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private NerdGeekDbEntities _context = App.GetContext();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void AuthorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorisationWindow authorisationWindow = new AuthorisationWindow();
            authorisationWindow.Show();
            Close();
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LoginTb.Text) && !string.IsNullOrEmpty(EmailTb.Text) && !string.IsNullOrEmpty(PhoneTb.Text) && 
                !string.IsNullOrEmpty(PasswordPb.Password) && !string.IsNullOrEmpty(RepeatPasswordPb.Password))
            {
                if (PasswordPb.Password == RepeatPasswordPb.Password)
                {
                    User newUser = new User()
                    {
                        Login = LoginTb.Text,
                        Email = EmailTb.Text,
                        Phone = PhoneTb.Text,
                        Password = PasswordPb.Password
                    };
                    _context.User.Add(newUser);
                    _context.SaveChanges();
                    MessageBoxHelper.Information("Вы успешно зарегистрировались!");
                    AuthorisationWindow authorisationWindow = new AuthorisationWindow();
                    authorisationWindow.Show();
                    Close();
                }
                else
                {
                    MessageBoxHelper.Error("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBoxHelper.Error("Заполните все поля!");
            }
        }
    }
}
