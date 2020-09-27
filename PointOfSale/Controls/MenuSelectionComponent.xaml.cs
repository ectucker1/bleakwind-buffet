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
