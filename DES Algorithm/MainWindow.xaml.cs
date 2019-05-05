using System;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Text;

namespace DES_Algorithm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Poprawić tak aby tekst w TextBox pojawiał się w środku
            InitializeComponent();
        }

        private void ButtonEncript_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxPlainText.Text!="" && TextBoxKey.Text!="")
            {
                DES.DES toEncript = new DES.DES(TextBoxPlainText.Text, TextBoxKey.Text);
                TextBoxEncriptedText.Text = toEncript.Encript();
            }
        }

        private void ButtonDecript_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEncriptedText.Text != "" && TextBoxKey.Text != "")
            {
                DES.DES toDecript = new DES.DES(TextBoxEncriptedText.Text, TextBoxKey.Text);
                TextBoxPlainText.Text = toDecript.Decript();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Converters.HexToBin("FF");
        }

        private void OpenPlainTextFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                TextBoxPlainText.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Unicode);
        }

        private void TextBoxPlainText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            switch (ConversionUtility.RecogniseDataSystem(TextBoxPlainText.Text.ToString()))
            {
                case 1:
                    RadioButtonPlainTextBin.IsChecked = true;
                    RadioButtonPlainTextHex.IsChecked = false;
                    RadioButtonPlainTextPlain.IsChecked = false;
                    break;
                case 2:
                    RadioButtonPlainTextBin.IsChecked = false;
                    RadioButtonPlainTextHex.IsChecked = true;
                    RadioButtonPlainTextPlain.IsChecked = false;
                    break;
                case 3:
                    RadioButtonPlainTextBin.IsChecked = false;
                    RadioButtonPlainTextHex.IsChecked = false;
                    RadioButtonPlainTextPlain.IsChecked = true;
                    break;
                default:
                    if (TextBoxPlainText.Text!=String.Empty)
                    {
                        TextBoxPlainText.Text = "Nieznany format.";
                    }
                    break;
            }
        }

        private void RadioButtonPlainTextBin_Checked(object sender, RoutedEventArgs e)
        {
            switch (ConversionUtility.RecogniseDataSystem(TextBoxPlainText.Text.ToString()))
            {
                case 1:
                    break;
                case 2:
                    TextBoxPlainText.Text = Converters.HexToBin(TextBoxPlainText.Text);
                    break;
                case 3:
                    TextBoxPlainText.Text = Converters.TextToBin(TextBoxPlainText.Text);
                    break;
                default:
                    TextBoxPlainText.Text = "Nieznany format.";
                    break;
            }
        }

        private void RadioButtonPlainTextHex_Checked(object sender, RoutedEventArgs e)
        {
            switch (ConversionUtility.RecogniseDataSystem(TextBoxPlainText.Text.ToString()))
            {
                case 1:
                    TextBoxPlainText.Text = Converters.BinToHex(TextBoxPlainText.Text);
                    break;
                case 2:
                    break;
                case 3:
                    TextBoxPlainText.Text = Converters.TextToHex(TextBoxPlainText.Text);
                    break;
                default:
                    TextBoxPlainText.Text = "Nieznany format.";
                    break;
            }
        }

        private void RadioButtonPlainTextPlain_Checked(object sender, RoutedEventArgs e)
        {
            switch (ConversionUtility.RecogniseDataSystem(TextBoxPlainText.Text.ToString()))
            {
                case 1:
                    TextBoxPlainText.Text = Converters.BinToText(TextBoxPlainText.Text);
                    break;
                case 2:
                    TextBoxPlainText.Text = Converters.HexToText(TextBoxPlainText.Text);
                    break;
                case 3:
                    break;
                default:
                    TextBoxPlainText.Text = "Nieznany format.";
                    break;
            }
        }

        private void ButtonFullEncript_Click(object sender, RoutedEventArgs e)
        {
            Encription encript = new Encription();
            encript.Show();
        }
    }
}
