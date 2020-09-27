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
 * Class name: OrderComponent.xaml.cs
 * Purpose: Define the order component, which has the main layout of the Point of Sale
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts customizing a new item by placing it in the ItemCustomizationComponent
        /// </summary>
        /// <param name="customizationControl">The Type of the customization page to use</param>
        public void StartItem(Type customizationControl)
        {
            controlItemCustomization.SwitchCustomizationLayout(customizationControl);
        }
    }
}
