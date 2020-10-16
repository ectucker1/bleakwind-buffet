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
 * Class name: OrderPreviewComponent.xaml.cs
 * Purpose: Define the OrderPreviewComponent
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for OrderPreviewComponent.xaml
    /// </summary>
    public partial class OrderPreviewComponent : UserControl
    {
        /// <summary>
        /// Returns the order item currently selected in the items list
        /// </summary>
        public IOrderItem SelectedItem => listViewItems.SelectedItem as IOrderItem;

        public OrderPreviewComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the selected item of the items list to the given item
        /// </summary>
        /// <param name="item">The item to select</param>
        public void SelectItem(IOrderItem item)
        {
            listViewItems.SelectedItem = item;
        }

        /// <summary>
        /// Enables the Submit Order button
        /// </summary>
        public void EnableOrderSubmission()
        {
            buttonSubmitOrder.Content = "Submit Order";
        }

        /// <summary>
        /// Switches the Submit Order button to the Return to Order button
        /// </summary>
        public void DisableOrderSubmission()
        {
            buttonSubmitOrder.Content = "Return to Order";
        }

        /// <summary>
        /// Event handler called to start payment when the Submit Order button is clicked
        /// </summary>
        /// <param name="sender">The Submit Order button</param>
        /// <param name="e">Click event arguments</param>
        public void OnSubmitOrderClicked(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            if (sender is Button button)
            {
                // Determine which mode the button is in
                // This could probably be better done with a custom class
                if (button.Content is string str)
                {
                    if (str.Contains("Submit"))
                    {
                        orderComponent.ShowPaymentScreen();
                    }
                    else
                    {
                        orderComponent.ShowEditingScreen();
                    }
                }
            }
        }

        /// <summary>
        /// Event handler called to create a new order when the Cancel Order button is clicked
        /// </summary>
        /// <param name="sender">The Cancel Order button</param>
        /// <param name="e">Click event arguments</param>
        public void OnCancelOrderClicked(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Order = new Order();
            orderComponent.ShowEditingScreen();
        }
    }
}
