using BleakwindBuffet.Data;
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
 * Class name: ItemCustomizationComponent.xaml.cs
 * Purpose: Define the interactions with the ItemCustomizationComponent
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for ItemCustomizationComponent.xaml
    /// </summary>
    public partial class ItemCustomizationComponent : UserControl
    {
        /// <summary>
        /// Creates and initializes the ItemCustomizationComponent
        /// </summary>
        public ItemCustomizationComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the Discard Item button is clicked, remove the item from the list
        /// </summary>
        /// <param name="sender">The Discard Item button</param>
        /// <param name="e">Click event arguments</param>
        public void OnDiscardItemClicked(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.RemoveCurrentItem();
        }
    }
}
