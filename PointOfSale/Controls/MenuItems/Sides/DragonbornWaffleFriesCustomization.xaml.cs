using BleakwindBuffet.Data.Sides;
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
 * Class name: DragonbornWaffleFriesCustomization.xaml.cs
 * Purpose: Defines the customization options for the Dragonborn Waffle Fries
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Sides
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFriesCustomization.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesCustomization : UserControl
    {
        public DragonbornWaffleFriesCustomization()
        {
            InitializeComponent();
            DataContext = new DragonbornWaffleFries();
        }
    }
}
