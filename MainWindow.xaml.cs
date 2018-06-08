using PZ_generatory.AdminPanel;
using PZ_generatory.Menu;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            

            WrapMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemStronaGłówna":
                    usc = new UserControlStronaGłówna();
                    WrapMain.Children.Add(usc);
                    break;
                case "ItemGeneratory":
                    usc = new UserControlGeneratory();
                    WrapMain.Children.Add(usc);
                    break;
                case "ItemSzyfrator":
                    usc = new UserControlSzyfrator();
                    WrapMain.Children.Add(usc);
                    break;
                case "ItemTesty":
                    usc = new FipsTestsUserControl();
                    WrapMain.Children.Add(usc);
                    break;
                case "ItemQuizTematyczny":
                    usc = new UserControlQuizTematyczny();
                    WrapMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void ButtonAdminPanel_Click(object sender, RoutedEventArgs e)
        {

            ChangeMainUserControl(new LoginToAdminPanel());
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainUserControl(new UserControlAbout());
        }

        private void ButtonAuthors_Click(object sender, RoutedEventArgs e)
        {
            ChangeMainUserControl(new UserControlAuthors());
        }

        private void ChangeMainUserControl(UserControl userControl)
        {
            WrapMain.Children.Clear();
            WrapMain.Children.Add(userControl);
        }
    
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

    }
}
