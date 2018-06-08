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
    /// Interaction logic for UserControlGeneratory.xaml
    /// </summary>
    public partial class UserControlGeneratory : UserControl
    {
        public UserControlGeneratory()
        {
            InitializeComponent();
        }

        SolidColorBrush active = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
        SolidColorBrush normal = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF267BB6"));

        private void Progowy_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_progowy();
            GridGeneratory.Children.Add(usc);
            Progowy.Background = active;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Rueppela_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_rueppela();
            Progowy.Background = normal;
            Rueppela.Background = active;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Rozrzedzający_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_rozrzedzający();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = active;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Geffego_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_geffego();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = active;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Stop_and_go_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_stop_and_go();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = active;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Gollmana_Click(object sender, RoutedEventArgs e)
        {

            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_gollmana();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = active;
            Obcinający.Background = normal;
            Samoobcinający.Background = normal;
        }

        private void Obcinający_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_obcinający();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = active;
            Samoobcinający.Background = normal;
        }

        private void Samoobcinający_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridGeneratory.Children.Clear();
            usc = new UserControl_samoobcinający();
            Progowy.Background = normal;
            Rueppela.Background = normal;
            Rozrzedzający.Background = normal;
            Geffego.Background = normal;
            Stop_and_go.Background = normal;
            Gollmana.Background = normal;
            Obcinający.Background = normal;
            Samoobcinający.Background = active;
        }
    }
}
