using BleakwindBuffet.Data.Drinks;
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

/*
 * Author: Ethan Tucker
 * Class name: SailorSodaCustomization.xaml.cs
 * Purpose: Defines the customization options for the Sailor Soda
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Drinks
{
    /// <summary>
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        public SailorSodaCustomization()
        {
            InitializeComponent();
            DataContext = new SailorSoda();
        }
    }
}
