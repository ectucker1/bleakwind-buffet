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

namespace BleakwindBuffet.PointOfSale.Controls.MenuItems.Fields
{
    /// <summary>
    /// Interaction logic for BooleanField.xaml
    /// </summary>
    public partial class BooleanField : UserControl
    {
        #region FieldName Property

        public string FieldName
        {
            get => (string) GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        public static readonly DependencyProperty FieldNameProperty = DependencyProperty.Register(nameof(FieldName), typeof(string), typeof(BooleanField));

        #endregion FieldName Property

        #region FieldValue Property

        public bool FieldValue
        {
            get => (bool) GetValue(FieldValueProperty);
            set => SetValue(FieldValueProperty, value);
        }

        public static readonly DependencyProperty FieldValueProperty = DependencyProperty.Register(nameof(FieldValue), typeof(bool), typeof(BooleanField));

        #endregion FieldValue Property

        public BooleanField()
        {
            InitializeComponent();
        }
    }
}
