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
 * Class name: MenuItemButtonComponent.xaml.cs
 * Purpose: Define a button which can be clicked to add an item to the menu
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for MenuItemButtonComponent.xaml
    /// </summary>
    public partial class MenuItemButtonComponent : Button
    {
        #region ItemName Property

        /// <summary>
        /// Gets or sets the name of the menu item for this button
        /// </summary>
        public string ItemName
        {
            get => (string) GetValue(ItemNameProperty);
            set => SetValue(ItemNameProperty, value);
        }

        /// <summary>
        /// Dependency property used to access and set the item name in XAML
        /// </summary>
        public static readonly DependencyProperty ItemNameProperty = DependencyProperty.Register(nameof(ItemName), typeof(string), typeof(MenuItemButtonComponent));

        #endregion ItemName Property

        #region ItemCustomizationControl Property

        /// <summary>
        /// Gets or sets the control to be used to customize this item
        /// </summary>
        public Type ItemCustomizationControl
        {
            get => (Type) GetValue(ItemCustomizationControlProperty);
            set => SetValue(ItemCustomizationControlProperty, value);
        }

        /// <summary>
        /// Dependency property used to access and set the item customization control in XAML
        /// </summary>
        public static readonly DependencyProperty ItemCustomizationControlProperty = DependencyProperty.Register(nameof(ItemCustomizationControl), typeof(Type), typeof(MenuItemButtonComponent));

        #endregion ItemCustomizationControl Property

        /// <summary>
        /// Creates and initialized a new MenuItemButtonComponent
        /// </summary>
        public MenuItemButtonComponent()
        {
            InitializeComponent();
        }
    }
}
