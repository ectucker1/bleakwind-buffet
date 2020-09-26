using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ItemSize = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for SizeField.xaml
    /// </summary>
    public partial class SizeField : UserControl
    {
        public SizeField()
        {
            InitializeComponent();
        }

        public ItemSize SelectedSize
        {
            get
            {
                // Comparision to true needed because IsChecked is type bool?
                if (radioLarge.IsChecked == true)
                {
                    return ItemSize.Large;
                }
                else if (radioMedium.IsChecked == true)
                {
                    return ItemSize.Medium;
                }
                else
                {
                    return ItemSize.Small;
                }
            }
        }
    }
}
