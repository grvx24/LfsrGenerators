using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PZ_generatory.AdminPanel
{
    /// <summary>
    /// Interaction logic for UserControlGeneratory.xaml
    /// </summary>
    public partial class LoginToAdminPanel : UserControl
    {
        public LoginToAdminPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(passwordBox.Password == "Monster")
            {
                Main.Children.Clear();
                Main.Children.Add(new UserControlAdminPanel());
            }
            else
            {
                Main.Background = Brushes.OrangeRed;
            }
        }
    }
}

