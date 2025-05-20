using NerdGeek.Model;
using NerdGeek.Views.Windows;
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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        private NerdGeekDbEntities _context = App.GetContext();
        public OrdersPage()
        {
            InitializeComponent();
            OrdersLb.ItemsSource = _context.Order.ToList();    
        }

        private void OrdersLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddEditOrderWindow addEditOrderWindow = new AddEditOrderWindow(OrdersLb.SelectedItem as Order);
            if (addEditOrderWindow.ShowDialog() == true)
            {
                OrdersLb.ItemsSource = _context.Order.ToList();    
            }
        }
    }
}
