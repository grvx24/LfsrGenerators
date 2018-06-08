﻿using LFSR_Generators;
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

namespace PZ_generatory.Generators.Samoobcinajacy
{
    /// <summary>
    /// Interaction logic for Settings_samoobcinajacy.xaml
    /// </summary>
    public partial class Settings_samoobcinajacy : UserControl
    {
        public Settings_samoobcinajacy()
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
            int parsed;
            if (!int.TryParse(lfsr1.Text, out parsed))
            {
                MessageBox.Show("Wartości początkowe rejestrów muszą być liczbą.");
                return;
            }
            else if ((lfsr1.Text).ToString().Length == 0)
            {
                MessageBox.Show("Uzupełnij pole z wartością początkowom rejestru.");
                return;
            }

            var registersLength = Convert.ToInt32(RegisterLength_ComboBox.SelectedItem);

            var boolArray = Convert.ToString(parsed, 2).Select(str => str.Equals('1')).Take(registersLength).ToArray();
            var bitArray = new BitArray(registersLength);
            for (int j = 0; j < boolArray.Length; j++)
            {
                bitArray[j] = boolArray[j];
            }

            int numOfLfsr = 1;
            Lfsr[] lfsr = new Lfsr[numOfLfsr];
                lfsr[0] = new Lfsr(registersLength);
                TextBox tb = (TextBox)this.FindName("lfsr1");
                lfsr[0].SetRegisterValues(bitArray);
            

            wynik.Clear();
            LfsrGenerator generator = new SelfShrinkingGenerator(lfsr);
            if (typ.SelectedIndex == 0)
            {
                var gen = generator.GenerateBitsAsChars(Convert.ToInt32(series_length.Text));
                wynik.Text = new string(gen);
            }
            else if (typ.SelectedIndex == 1)
            {
                var gen1 = generator.GenerateBytes(Convert.ToInt32(series_length.Text));
                wynik.Text = BitConverter.ToString(gen1);
            }
            else if (typ.SelectedIndex == 2)
            {
                var gen1 = generator.GenerateIntegers(Convert.ToInt32(series_length.Text));
                wynik.Text = String.Join(" ", gen1.Select(p => p.ToString()).ToArray());
            }

        }
    }
}
