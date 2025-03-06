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
    /// Логика взаимодействия для PcPage.xaml
    /// </summary>
    public partial class PcPage : Page
    {
        private NerdGeekDbEntities _context = App.GetContext();
        private List<Product> _products = new List<Product>();
        public PcPage()
        {
            InitializeComponent();
            _products = _context.Product.Where(p => p.Category.Id == 1).ToList();
            ProductsLb.ItemsSource = _products;
        }

        private void GamingHl_Click(object sender, RoutedEventArgs e)
        {
            ProductsLb.ItemsSource = _products.Where(p => p.Price > 100000);
        }

        private void OptimalHl_Click(object sender, RoutedEventArgs e)
        {
            ProductsLb.ItemsSource = _products.Where(p => p.Price <= 100000);
        }
    }
}
