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

namespace DES_Algorithm.DescriptionPages
{
    /// <summary>
    /// Logika interakcji dla klasy Keys.xaml
    /// </summary>
    public partial class Keys : Page
    {
        public Keys()
        {
            InitializeComponent();
        }

        private void KeysInitBtn_Click(object sender, RoutedEventArgs e)
        {

            KeysFrame.NavigationService.Navigate(new KeysPages.KeyInit());
        }
    }
}
