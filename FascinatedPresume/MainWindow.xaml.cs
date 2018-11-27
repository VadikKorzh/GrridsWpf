using FascinatedPresume.Converters;
using FascinatedPresume.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FascinatedPresume
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitGridControl();
        }

        private void InitGridControl()
        {
            DataTable gridSourceTable = new DataTable();
            DataColumn dataColumn = new DataColumn();

            gridSourceTable.Columns.Add("Planet", typeof(String));
            gridSourceTable.Columns.Add("Latitude", typeof(Double));
            gridSourceTable.Columns.Add("Longitude", typeof(Double));

            gridSourceTable.Rows.Add("Earth", 123.11, 55.2342);
            gridSourceTable.Rows.Add("Jupiter", -23.561, 85.2);
            gridSourceTable.Rows.Add("Mars", 57.78, -1.008);

            testGridControl.ItemsSource = gridSourceTable;
        }

       

        private void ColumnMenuButton_Click(Object sender, RoutedEventArgs e)
        {
            var parent = LogicalTreeHelper.GetParent((DependencyObject)sender);
            

            Int32 childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i) as Popup;
                if (null != child)
                {
                    if (child.Name.Equals("menuPopup"))
                    {
                        child.IsOpen = true;
                        e.Handled = true;
                    }
                }
            }
        }

        private void ListBox_SelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            ListBoxItem item = lb.SelectedItem as ListBoxItem;
            MessageBox.Show($"Action: {item.Content}", "Column Standardization");
        }

        private void TypeButton_Click(Object sender, RoutedEventArgs e)
        {
            var parent = LogicalTreeHelper.GetParent((DependencyObject)sender);


            Int32 childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i) as Popup;
                if (null != child)
                {
                    if (child.Name.Equals("typePopup"))
                    {
                        child.IsOpen = true;
                        e.Handled = true;
                    }
                }
            }
        }

    }
}
