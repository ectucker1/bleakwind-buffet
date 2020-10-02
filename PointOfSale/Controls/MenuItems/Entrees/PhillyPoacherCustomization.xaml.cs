﻿using BleakwindBuffet.Data.Entrees;
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
 * Class name: PhillyPoacherCustomization.xaml.cs
 * Purpose: Defines the customization options for the Philly Poacher
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Entrees
{
    /// <summary>
    /// Interaction logic for PhillyPoacherCustomization.xaml
    /// </summary>
    public partial class PhillyPoacherCustomization : UserControl
    {
        public PhillyPoacherCustomization()
        {
            InitializeComponent();
            DataContext = new PhillyPoacher();
        }
    }
}
