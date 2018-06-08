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
    /// Interaction logic for UserControlQuizTematyczny.xaml
    /// </summary>
    public partial class UserControlQuizTematyczny : UserControl
    {
        public UserControlQuizTematyczny()
        {
            InitializeComponent();
        }

        

        private void Generatory_liniowe_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridQuiz.Children.Clear();
            usc = new Quiz_generatory();
            GridQuiz.Children.Add(usc);
            }

        private void Szyfry_proste_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridQuiz.Children.Clear();
            usc = new Quiz_szyfry();
            GridQuiz.Children.Add(usc);
        }

        private void Testy_FIPS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Funkcje_skrótu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Szyfratory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
