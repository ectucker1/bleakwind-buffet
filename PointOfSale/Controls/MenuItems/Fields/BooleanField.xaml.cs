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
 * Class name: BooleanField.xaml.cs
 * Purpose: Define the interactions with a BooleanField
 */
namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for BooleanField.xaml
    /// </summary>
    public partial class BooleanField : UserControl
    {
        #region FieldName Property

        /// <summary>
        /// Gets or sets the name of this field
        /// </summary>
        public string FieldName
        {
            get => (string) GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        /// <summary>
        /// Dependency property used to set the field name in XAML
        /// </summary>
        public static readonly DependencyProperty FieldNameProperty = DependencyProperty.Register(nameof(FieldName), typeof(string), typeof(BooleanField));

        #endregion FieldName Property

        #region FieldValue Property

        /// <summary>
        /// Gets or sets the value of this field
        /// </summary>
        public bool FieldValue
        {
            get => (bool) GetValue(FieldValueProperty);
            set => SetValue(FieldValueProperty, value);
        }

        /// <summary>
        /// Dependency property used to access and set the field value in XAML
        /// </summary>
        public static readonly DependencyProperty FieldValueProperty = DependencyProperty.Register(nameof(FieldValue), typeof(bool), typeof(BooleanField));

        #endregion FieldValue Property

        /// <summary>
        /// Creates and initializes a new BooleanField
        /// </summary>
        public BooleanField()
        {
            InitializeComponent();
        }
    }
}
