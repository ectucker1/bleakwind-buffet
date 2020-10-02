using BleakwindBuffet.Data.Entrees;
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
 * Class name: ThugsTBoneCustomization.xaml.cs
 * Purpose: Defines the customization options (or lack thereof) for the Thugs T-Bone
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Entrees
{
    /// <summary>
    /// Interaction logic for ThugsTBoneCustomization.xaml
    /// </summary>
    public partial class ThugsTBoneCustomization : UserControl
    {
        public ThugsTBoneCustomization()
        {
            InitializeComponent();
            DataContext = new ThugsTBone();
        }
    }
}
