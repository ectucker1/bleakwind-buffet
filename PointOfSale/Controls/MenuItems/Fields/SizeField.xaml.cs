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

/*
 * Author: Ethan Tucker
 * Class name: SizeField.xaml.cs
 * Purpose: Defines a field representing an item size
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for SizeField.xaml
    /// </summary>
    public partial class SizeField : UserControl
    {
        /// <summary>
        /// Creates and initialized a new size field
        /// </summary>
        public SizeField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the currently selected item size
        /// </summary>
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
