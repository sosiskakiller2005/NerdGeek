using NerdGeek.AppData;
using NerdGeek.Views.Pages;
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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            MainFrm.Navigate(new StartPage());
            FrameHelper.selectedFrame = MainFrm;
        }

        private void PCHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new PcPage());
        }

        private void LaptopsHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MonitorsHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KeyboardsHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MousesHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccesoriesHl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrdersHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OrdersPage());
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TranslateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfileHl_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ProfilePage(AuthorisationHelper.selectedUser));
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
