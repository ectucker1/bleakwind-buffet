using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
 * Class name: ComboCustomization.xaml.cs
 * Purpose: Defines the customization options for the Combo
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems
{
    /// <summary>
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : UserControl
    {
        public ComboCustomization()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        /// <summary>
        /// Event handler called when the data context is changed
        /// </summary>
        /// <param name="sender">The sender of the data context change event</param>
        /// <param name="e">DependencyPropertyChangedEvent arguments</param>
        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // Connect to the items PropertyChanged event
            // This is necessary to call ToString when
            if (e.NewValue is Combo combo)
            {
                ReplaceOfType(entreeSelections, combo.Entree);
                ReplaceOfType(sideSelections, combo.Side);
                ReplaceOfType(drinkSelections, combo.Drink);
            }
        }

        /// <summary>
        /// Replaces the item with the same type of the given IOrderItem with the given item
        /// </summary>
        /// <param name="list">The ListBox to replace from</param>
        /// <param name="item">An IOrderItem to replace in the list</param>
        void ReplaceOfType(ListBox list, IOrderItem item)
        {
            var items = new List<IOrderItem>(list.ItemsSource.Cast<IOrderItem>());

            // Get the index of the item in the list with the same type as the item
            int i;
            for (i = 0; i < items.Count; i++)
            {
                if (items[i].GetType() == item.GetType())
                {
                    break;
                }
            }

            // Remove the item
            items[i] = item;

            list.ItemsSource = items;
        }

        void OnEntreeSelectorFocused(object sender, RoutedEventArgs e)
        {
            entreeCustomization.Visibility = Visibility.Visible;
            sideCustomization.Visibility = Visibility.Collapsed;
            drinkCustomization.Visibility = Visibility.Collapsed;
        }

        void OnSideSelectorFocused(object sender, RoutedEventArgs e)
        {
            entreeCustomization.Visibility = Visibility.Collapsed;
            sideCustomization.Visibility = Visibility.Visible;
            drinkCustomization.Visibility = Visibility.Collapsed;
        }

        void OnDrinkSelectorFocused(object sender, RoutedEventArgs e)
        {
            entreeCustomization.Visibility = Visibility.Collapsed;
            sideCustomization.Visibility = Visibility.Collapsed;
            drinkCustomization.Visibility = Visibility.Visible;
        }
    }
}
