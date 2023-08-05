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

namespace exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     public partial class MainWindow : Window
    {
        private examContext _context = new examContext();
        public List<Name> names { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            fullicollection(_context);
            
        }
        public void fullicollection(examContext context)
        {
            _context = context;
            names = _context.Names.ToList();
            nnnname.ItemsSource = names;
        }
    }
}
