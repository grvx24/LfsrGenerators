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
    /// Interaction logic for UserControlTesty.xaml
    /// </summary>
    public partial class UserControlTesty : UserControl
    {
        public UserControlTesty()
        {
            InitializeComponent();
            LoadTestName();
        }

        private void LoadTestName()
        {
            List<string> generators = new List<string>();
            generators.Add("Test Pojdeynczych Bitów");
            generators.Add("Test Serii");
            generators.Add("Test Długiej Serii");
            generators.Add("Test Pokerowy");

            ItemContorlWrapPranel.ItemsSource = generators;
        }
    }

}
