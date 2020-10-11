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

        public void OnSubmitOrderClicked(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Order = new Order();
        }

        public void OnCancelOrderClicked(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Order = new Order();
        }
    }
}
