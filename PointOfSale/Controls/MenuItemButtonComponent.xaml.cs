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
    /// Interaction logic for MenuItemButtonComponent.xaml
    /// </summary>
    public partial class MenuItemButtonComponent : UserControl
    {
        #region ItemName Property

        public string ItemName
        {
            get => (string) GetValue(ItemNameProperty);
            set => SetValue(ItemNameProperty, value);
        }

        public static readonly DependencyProperty ItemNameProperty = DependencyProperty.Register(nameof(ItemName), typeof(string), typeof(MenuItemButtonComponent));

        #endregion ItemName Property

        public MenuItemButtonComponent()
        {
            InitializeComponent();
        }
    }
}
