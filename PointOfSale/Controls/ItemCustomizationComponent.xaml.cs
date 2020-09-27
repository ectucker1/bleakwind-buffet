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
        /// Switches to the given customization page
        /// </summary>
        /// <param name="customizationControl">The Type of the customization page to use</param>
        public void SwitchCustomizationLayout(Type customizationControl)
        {
            var layout = Activator.CreateInstance(customizationControl);
            if (layout is UIElement control)
            {
                containerCustomization.Child = control;
            }
        }

        /// <summary>
        /// When the Add Item button is clicked, adds an item to the order
        /// </summary>
        /// <param name="sender">The Add Item button</param>
        /// <param name="e">Click event arguments</param>
        public void OnAddItemClicked(object sender, RoutedEventArgs e)
        {
            ClearCustomizationLayout();
        }

        /// <summary>
        /// When the Discard Item button is clicked, clear the customization page
        /// </summary>
        /// <param name="sender">The Discard Item button</param>
        /// <param name="e">Click event arguments</param>
        public void OnDiscardItemClicked(object sender, RoutedEventArgs e)
        {
            ClearCustomizationLayout();
        }

        /// <summary>
        /// Clears the current customization page
        /// </summary>
        private void ClearCustomizationLayout()
        {
            containerCustomization.Child = null;
        }
    }
}
