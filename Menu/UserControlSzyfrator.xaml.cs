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

namespace PZ_generatory
{
    /// <summary>
    /// Interaction logic for UserControlSzyfrator.xaml
    /// </summary>
    public partial class UserControlSzyfrator : UserControl
    {
        public UserControlSzyfrator()
        {
            InitializeComponent();
        }

        private void Szyfrator_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new Encryptor();
            UserChoice.Children.Add(usc);
        }

        private void Deszyfrator_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new Decryptor();
            UserChoice.Children.Add(usc);
        }


    }
}
