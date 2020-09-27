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
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Define the MenuSelectionComponent, which lists all menu items
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Begins the customization of an item when a menu item is clicked
        /// </summary>
        /// <param name="sender">The MenuItemButtonComponent that was clicked</param>
        /// <param name="e">Click event arguments</param>
        private void OnMenuItemClick(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItemButtonComponent menuItem)
            {
                var orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.StartItem(menuItem.ItemCustomizationControl);
            }
        }
    }
}
