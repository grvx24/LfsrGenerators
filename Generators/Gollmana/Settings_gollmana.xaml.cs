using LFSR_Generators;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace PZ_generatory.Generators.Gollmana
{
    /// <summary>
    /// Interaction logic for Settings_gollmana.xaml
    /// </summary>
    public partial class Settings_gollmana : UserControl
    {
        public Settings_gollmana()
        {
            InitializeComponent();
            PrepareRegisterLenghtCombobox();
        }

        private void PrepareRegisterLenghtCombobox()
        {
            for (int i = 2; i <= 20; i++)
            {
                RegisterLength_ComboBox.Items.Add(i);
            }
            RegisterLength_ComboBox.SelectedIndex = 0;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(lfsr_amount.Text, out parsedValue))
            {
                MessageBox.Show("Musisz podać liczbę rejestrów.");
                return;
            }
            else if ((lfsr_amount.Text).ToString().Length == 0)
            {
                MessageBox.Show("Podaj liczbę rejestrów (nieparzysta).");
                return;
            }
            else if (Convert.ToInt32(lfsr_amount.Text) < 1)
            {
                MessageBox.Show("Liczba rejestrów musi być większa od zera.");
                return;
            }


            Generuj.IsEnabled = true;



            Lfsr_list.Children.Clear();
                List<string> registers = new List<string>();
                int numOfLfsr = Convert.ToInt32(lfsr_amount.Text);
                for (int i = 0; i < numOfLfsr; i++)
                {
                    TextBox textBox = new TextBox();
                    Label label = new Label();
                    textBox.Name = "textBox" +(i+1).ToString();
                    textBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF224BB6"));
                    textBox.HorizontalAlignment = HorizontalAlignment.Stretch;
                    label.Content = "LFSR " + (i + 1).ToString();
                    Lfsr_list.Children.Add(label);
                    Lfsr_list.Children.Add(textBox);
                }
        }

        private void wynik_txt_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (.txt)|.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    byte[] buffer = Encoding.Default.GetBytes(wynik.Text);
                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }
        }

        private byte[] ToByteArray(BitArray input)
        {
            if (input.Length % 8 != 0)
            {
                byte[] ret = new byte[(input.Length / 8)];
                for (int i = 0; i < input.Length - input.Length % 8; i += 8)
                {
                    int value = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        if (input[i + j])
                        {
                            value += 1 << (7 - j);
                        }
                    }
                    ret[i / 8] = (byte)value;
                }
                return ret;

            }
            else
            {
                byte[] ret = new byte[input.Length / 8];
                for (int i = 0; i < input.Length; i += 8)
                {
                    int value = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        if (input[i + j])
                        {
                            value += 1 << (7 - j);
                        }
                    }
                    ret[i / 8] = (byte)value;
                }
                return ret;
            }
        }

        private void wynik_bin_Click(object sender, RoutedEventArgs e)
        {
            var chars = (wynik.Text).ToCharArray();
            int rozmiar = ((wynik.Text).Length);
            BitArray a2 = new BitArray(rozmiar);
            for (int i = 0; i < rozmiar; i++)
            {

                if (chars[i] == '1')
                {
                    a2[i] = true;
                }
                if (chars[i] == '0')
                {
                    a2[i] = false;
                }
            }
            byte[] buffer = ToByteArray(a2);

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "bin files (.bin)|.bin";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            Nullable<bool> result = saveFileDialog1.ShowDialog();
            if (result == true)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    myStream.Write(buffer, 0, buffer.Length);

                    myStream.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int parsedValue;
           
            if (!int.TryParse(series_length.Text, out parsedValue))
            {
                MessageBox.Show("Długość ciągu do wygenerowania musi być liczbą całkowitą.");
                return;
            }
            else if ((series_length.Text).ToString().Length == 0)
            {
                MessageBox.Show("Podaj długość ciągu do wygenerowania.");
                return;
            }
            else if (Convert.ToInt32(series_length.Text) < 1)
            {
                MessageBox.Show("Długość ciągu do wygenerowania musi być większa od zera.");
                return;
            }

            int numOfLfsr = Convert.ToInt32(lfsr_amount.Text);
            Lfsr[] lfsr = new Lfsr[numOfLfsr];
            int[] parsed = new int[numOfLfsr];

            var registersLength = Convert.ToInt32(RegisterLength_ComboBox.SelectedItem);

            for (int i = 0; i < numOfLfsr; i++)
            {
                

                string s = ((TextBox)Lfsr_list.Children[((i+1)*2)-1]).Text;

                if (s.Length == 0)
                {
                    MessageBox.Show("Musisz podać wartości początkowe rejestrów.");
                    return;
                }

                else if (!int.TryParse(s, out parsed[i]))
                {
                    MessageBox.Show("Wartości początkowe rejestrów muszą być liczbą.");
                    return;
                }
                lfsr[i] = new Lfsr(registersLength);

                var boolArray = Convert.ToString(parsed[i], 2).Select(str => str.Equals('1')).Take(registersLength).ToArray();
                var bitArray = new BitArray(registersLength);
                for (int j = 0; j < boolArray.Length; j++)
                {
                    bitArray[j] = boolArray[j];
                }
                lfsr[i].SetRegisterValues(bitArray);
            }

            Stopwatch sw = new Stopwatch();
            wynik.Clear();
            LfsrGenerator generator = new CascadeGenerator(lfsr);
            if (typ.SelectedIndex == 0)
            {       
                sw.Start();
                var gen = generator.GenerateBitsAsChars(Convert.ToInt32(series_length.Text));
                sw.Stop();
                wynik.Text = new string(gen);
                sw.Reset();
            }
            else if(typ.SelectedIndex == 1)
            {
                sw.Start();
                var gen1 = generator.GenerateBytes(Convert.ToInt32(series_length.Text));
                sw.Stop();
                wynik.Text = BitConverter.ToString(gen1);

                sw.Reset();
            }
            else if (typ.SelectedIndex == 2)
            {
                sw.Start();
                var gen1 = generator.GenerateIntegers(Convert.ToInt32(series_length.Text));
                sw.Stop();
                wynik.Text = String.Join(" ", gen1.Select(p => p.ToString()).ToArray());
                sw.Reset();
            }

        }
    }
}
