using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ItemPreviewComponent.xaml
    /// </summary>
    public partial class ItemPreviewComponent : UserControl
    {
        public ItemPreviewComponent()
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
            if (e.NewValue is IOrderItem newItem)
            {
                newItem.PropertyChanged += OnItemPropertyChanged;
            }

            if (e.OldValue is IOrderItem oldItem)
            {
                oldItem.PropertyChanged -= OnItemPropertyChanged;
            }
        }

        /// <summary>
        /// Event handler called when the property of the displayed item is changed
        /// </summary>
        /// <param name="sender">The item displayed by this component</param>
        /// <param name="e">Property changed event arguments</param>
        void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // There's no way of knowing which properties actually change the ToString() result
            // So just update it every time
            textItemString.Text = DataContext.ToString();
        }
    }
}
