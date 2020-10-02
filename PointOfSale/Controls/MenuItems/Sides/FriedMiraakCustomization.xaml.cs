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
 * Class name: FriedMiraakCustomization.xaml.cs
 * Purpose: Defines the customization options for the Fried Miraak
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Sides
{
    /// <summary>
    /// Interaction logic for FriedMiraakCustomization.xaml
    /// </summary>
    public partial class FriedMiraakCustomization : UserControl
    {
        public FriedMiraakCustomization()
        {
            InitializeComponent();
            DataContext = new FriedMiraak();
        }
    }
}
