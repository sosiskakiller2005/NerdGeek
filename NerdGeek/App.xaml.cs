using NerdGeek.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NerdGeek
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static NerdGeekDbEntities _context;
        public static NerdGeekDbEntities GetContext()
        {
            if (_context == null)
            {
                _context = new NerdGeekDbEntities();
            }
            return _context;
        }
    }
}
