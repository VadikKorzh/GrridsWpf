using FascinatedPresume.Converters;
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
using System.Windows.Shapes;

namespace FascinatedPresume
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            var res = Application.Current.Resources["column2BackgroundConverter"] as String2ColorConverter;
            res.col2Colors.Add("Planet", Colors.Green);
            res.col2Colors.Add("Latitude", Colors.RoyalBlue);
            res.col2Colors.Add("Longitude", Colors.Thistle);

            new MainWindow().Show();
            this.Close();
        }

        private void Button_Click_1(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            DateTime dt = (DateTime)btn.Tag;
            MessageBox.Show(dt.ToString());
        }
    }
}
