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
    /// Логика взаимодействия для AddEditOrderWindow.xaml
    /// </summary>
    public partial class AddEditOrderWindow : Window
    {
        private NerdGeekDbEntities _context = App.GetContext();
        private Order _selectedOrder;
        public AddEditOrderWindow(Order selectedOrder)
        {
            InitializeComponent();
            _selectedOrder = selectedOrder;
            StatusCmb.ItemsSource = _context.Status.ToList();
            StatusCmb.DisplayMemberPath = "Name";
            OrderGrid.DataContext = selectedOrder;
        }
    }
}
