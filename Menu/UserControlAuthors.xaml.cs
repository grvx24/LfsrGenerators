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

namespace PZ_generatory.Menu
{
    /// <summary>
    /// Interaction logic for UserControlAuthors.xaml
    /// </summary>
    public partial class UserControlAuthors : UserControl
    {
        public UserControlAuthors()
        {
            InitializeComponent();
        }

        private void MouseEnter_P(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/nosacz_2.jpg", UriKind.Absolute);
            logo.EndInit(); 
            Paulina.Source = logo;
        }
        private void MouseLeave_P(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/woman.jpg", UriKind.Absolute);
            logo.EndInit(); 
            Paulina.Source = logo;
        }
        private void MouseEnter_K(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/nosacz.jpg", UriKind.Absolute);
            logo.EndInit();
            Kamil.Source = logo;
        }
        private void MouseLeave_K(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/man.jpg", UriKind.Absolute);
            logo.EndInit();
            Kamil.Source = logo;
        }

        private void MouseEnter_H(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/nosacz_1.jpg", UriKind.Absolute);
            logo.EndInit();
            Hubert.Source = logo;
        }
        private void MouseLeave_H(object sender, MouseEventArgs e)
        {
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Images/man.jpg", UriKind.Absolute);
            logo.EndInit();
            Hubert.Source = logo;
        }


    }
}
