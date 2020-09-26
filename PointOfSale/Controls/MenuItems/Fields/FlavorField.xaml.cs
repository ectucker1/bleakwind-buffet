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

namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for FlavorField.xaml
    /// </summary>
    public partial class FlavorField : UserControl
    {
        public FlavorField()
        {
            InitializeComponent();
        }

        public SodaFlavor SelectedSize
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
