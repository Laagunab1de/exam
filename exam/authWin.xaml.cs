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
    /// Логика взаимодействия для authWin.xaml
    /// </summary>
    public partial class authWin : Window
    {
        private string Login;
        private string Passwrd;
        private examContext _context = new examContext();
        public List<Name> names { get; set; }
        public authWin()
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
            Login = login.Text;
            Passwrd = passwrd.Text;
            if(string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Passwrd))
            {
                MessageBox.Show("empty");
            }
            else if(names.FirstOrDefault(s => s.Name1 == Passwrd && s.Login == Login) != null)
            {
                MessageBox.Show("uraaa");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
