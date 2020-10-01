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
using ItemSize = BleakwindBuffet.Data.Enums.Size;

/*
 * Author: Ethan Tucker
 * Class name: SizeField.xaml.cs
 * Purpose: Defines a field representing an item size
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for SizeField.xaml
    /// </summary>
    public partial class SizeField : UserControl
    {
        #region FieldName Property

        /// <summary>
        /// Gets or sets the name of this field
        /// </summary>
        public string FieldName
        {
            get => (string)GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        /// <summary>
        /// Dependency property used to set the field name in XAML
        /// </summary>
        public static readonly DependencyProperty FieldNameProperty = DependencyProperty.Register(nameof(FieldName), typeof(string), typeof(SizeField));

        #endregion FieldName Property

        #region FieldValue Property

        /// <summary>
        /// Gets or sets the value of this field
        /// </summary>
        public ItemSize FieldValue
        {
            get => (ItemSize)GetValue(FieldValueProperty);
            set => SetValue(FieldValueProperty, value);
        }

        /// <summary>
        /// Dependency property used to access and set the field value in XAML
        /// </summary>
        public static readonly DependencyProperty FieldValueProperty = DependencyProperty.Register(nameof(FieldValue), typeof(ItemSize), typeof(SizeField),
            new FrameworkPropertyMetadata
            {
                BindsTwoWayByDefault = true,
                DefaultUpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            });

        #endregion FieldValue Property

        /// <summary>
        /// Creates and initialized a new size field
        /// </summary>
        public SizeField()
        {
            InitializeComponent();
        }
    }
}
