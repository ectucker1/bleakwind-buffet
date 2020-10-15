using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
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
        private Order order;
        /// <summary>
        /// The current order being edited by the order component.
        /// This will be set to the data context.
        /// </summary>
        public Order Order {
            get => order;
            set
            {
                order = value;
                DataContext = order;
            }
        }

        public OrderComponent()
        {
            InitializeComponent();
            Order = new Order();
        }

        /// <summary>
        /// Adds a new item with the given type to the order
        /// </summary>
        /// <param name="itemType">The Type of the item to add</param>
        public void AddItem(Type itemType)
        {
            var instance = Activator.CreateInstance(itemType);
            if (instance is IOrderItem item)
            {
                Order.Add(item);
                controlOrderPreview.SelectItem(item);
            }
            else
            {
                throw new ArgumentException("Type of items added must be descendants of IOrderItem");
            }
        }

        /// <summary>
        /// Removes the currently selected item from the order
        /// </summary>
        public void RemoveCurrentItem()
        {
            Order.Remove(controlOrderPreview.SelectedItem);
        }

        /// <summary>
        /// Hides the order customization components and shows the payment screen
        /// </summary>
        public void StartPayment()
        {
            controlPaymentChoice.Visibility = Visibility.Visible;
            controlMenuSelection.Visibility = Visibility.Collapsed;
            controlItemCustomization.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Hides the payment screen and shows the order customization components
        /// </summary>
        public void FinishPayment()
        {
            controlPaymentChoice.Visibility = Visibility.Collapsed;
            controlMenuSelection.Visibility = Visibility.Visible;
            controlItemCustomization.Visibility = Visibility.Visible;
        }
    }
}
