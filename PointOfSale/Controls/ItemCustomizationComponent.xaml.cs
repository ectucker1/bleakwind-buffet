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
    /// Interaction logic for ItemCustomizationComponent.xaml
    /// </summary>
    public partial class ItemCustomizationComponent : UserControl
    {
        public ItemCustomizationComponent()
        {
            InitializeComponent();
        }

        public void SwitchCustomizationLayout(Type customizationControl)
        {
            var layout = Activator.CreateInstance(customizationControl);
            if (layout is UIElement control)
            {
                containerCustomization.Child = control;
            }
        }

        public void OnAddItemClicked(object sender, RoutedEventArgs e)
        {
            ClearCustomizationLayout();
        }

        public void OnDiscardItemClicked(object sender, RoutedEventArgs e)
        {
            ClearCustomizationLayout();
        }

        private void ClearCustomizationLayout()
        {
            containerCustomization.Child = null;
        }
    }
}
