using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PZ_generatory
{
    public partial class UserControlGeneratory : UserControl
    {
        public UserControlGeneratory()
        {
            InitializeComponent();

            LoadGeenratorsName();
        }

        private void LoadGeenratorsName()
        {
            List<string> generators = new List<string>();
            generators.Add("Generator Progowy");
            generators.Add("Generator Samodecymujący Rueppela");
            generators.Add("Generator Geffego");
            generators.Add("Przemienny Generator stop-and-go");
            generators.Add("Kaskada Gollmana");
            generators.Add("Generator Obcinający");
            generators.Add("Generator Samoobcinający");

            ItemContorlWrapPranel.ItemsSource = generators;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            TextBlock textblock = button.Content as TextBlock;
            string GeneratorName = textblock.Text;

            try
            {
                UserControl usc;
                switch (GeneratorName)
                {
                    case "Generator Progowy":
                        usc = new UserControl_progowy();
                        break;
                    case "Generator Samodecymujący Rueppela":
                        usc = new UserControl_rueppela();
                        break;
                    case "Generator Geffego":
                        usc = new UserControl_geffego();
                        break;
                    case "Przemienny Generator stop-and-go":
                        usc = new UserControl_stop_and_go();
                        break;
                    case "Kaskada Gollmana":
                        usc = new UserControl_gollmana();
                        break;
                    case "Generator Obcinający":
                        usc = new UserControl_obcinający();
                        break;
                    case "Generator Samoobcinający":
                        usc = new UserControl_samoobcinający();
                        break;
                    default:
                        throw new Exception("Generatory - brak takiego generatora");
                }

                UserControlChange.Children.Add(usc);
            }catch(Exception catchedException)
            {
                Console.WriteLine(catchedException.Message);
            }
        }
    }
}
