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
using BleakwindBuffet.Data.Enums;

/*
 * Author: Ethan Tucker
 * Class name: FlavorField.xaml.cs
 * Purpose: Defines a field representing a soda flavor
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for FlavorField.xaml
    /// </summary>
    public partial class FlavorField : UserControl
    {
        /// <summary>
        /// Creates and initializes new flavor field
        /// </summary>
        public FlavorField()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the currently selected soda flavor
        /// </summary>
        public SodaFlavor SelectedFlavor
        {
            get
            {
                // Comparision to true needed because IsChecked is type bool?
                if (radioBlackberry.IsChecked == true)
                {
                    return SodaFlavor.Blackberry;
                }
                else if (radioGrapefruit.IsChecked == true)
                {
                    return SodaFlavor.Grapefruit;
                }
                else if (radioLemon.IsChecked == true)
                {
                    return SodaFlavor.Lemon;
                }
                else if (radioPeach.IsChecked == true)
                {
                    return SodaFlavor.Peach;
                }
                else if (radioWatermelon.IsChecked == true)
                {
                    return SodaFlavor.Watermelon;
                }
                else
                {
                    return SodaFlavor.Cherry;
                }
            }
        }
    }
}
