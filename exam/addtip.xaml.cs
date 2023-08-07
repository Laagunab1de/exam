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

namespace exam
{
    /// <summary>
    /// Логика взаимодействия для addtip.xaml
    /// </summary>
    public partial class addtip : Window
    {
        private examContext _context = new examContext();
        public List<Name> names { get; set; }
        public addtip()
        {
            InitializeComponent();
            fullicollection(_context);
        }
        public void fullicollection(examContext context)
        {
            _context = context;
            names = _context.Names.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name namee = new Name()
            {
                Id = 350,
                Name1 = name.Text,
                Surname = surname.Text,
                Login = login.Text
            };

            _context.Names.Add(namee);
            _context.SaveChanges();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
