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
 * Class name: CashAmountComponent.xaml.cs
 * Purpose: Takes input for an amount of currency, and displays the amount that needs to be given as change
 */
namespace BleakwindBuffet.PointOfSale.Controls.Payment
{
    /// <summary>
    /// Interaction logic for CashAmountComponent.xaml
    /// </summary>
    public partial class CashAmountComponent : UserControl
    {
        /// <summary>
        /// The value of the currency this control represents
        /// </summary>
        public double Currency {
            get => (double) GetValue(CurrencyProperty);
            set => SetValue(CurrencyProperty, value);
        }

        /// <summary>
        /// Dependency property for the Currency property
        /// </summary>
        public static readonly DependencyProperty CurrencyProperty = DependencyProperty.Register(nameof(Currency), typeof(double), typeof(CashAmountComponent));

        /// <summary>
        /// The quantity of this currency given by the customer
        /// </summary>
        public int CustomerGiven
        {
            get => (int)GetValue(CustomerGivenProperty);
            set => SetValue(CustomerGivenProperty, value);
        }

        /// <summary>
        /// Metadata for the CustomerGiven dependency property
        /// Makes that property bind two ways by default
        /// </summary>
        private static FrameworkPropertyMetadata customerGivenMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender);

        /// <summary>
        /// Dependency property for the CustomerGiven property
        /// </summary>
        public static readonly DependencyProperty CustomerGivenProperty = DependencyProperty.Register(nameof(CustomerGiven), typeof(int), typeof(CashAmountComponent), customerGivenMetadata);

        /// <summary>
        /// The amount of change that should be given in this controls currency
        /// </summary>
        public int ChangeGiven
        {
            get => (int)GetValue(ChangeGivenProperty);
            set => SetValue(ChangeGivenProperty, value);
        }

        /// <summary>
        /// Dependency property for the ChangeGiven property
        /// </summary>
        public static readonly DependencyProperty ChangeGivenProperty = DependencyProperty.Register(nameof(ChangeGiven), typeof(int), typeof(CashAmountComponent));

        /// <summary>
        /// Creates a new CashAmountComponent
        /// </summary>
        public CashAmountComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the amount of currency given by the customer when the plus button is clicked
        /// </summary>
        /// <param name="sender">The Plus button</param>
        /// <param name="e">Click event arguments</param>
        public void OnAddCurrencyClick(object sender, RoutedEventArgs e)
        {
            CustomerGiven++;
        }

        /// <summary>
        /// Increases the amount of currency given by the customer when the minus button is clicked
        /// </summary>
        /// <param name="sender">The Minus button</param>
        /// <param name="e">Click event arguments</param>
        public void OnRemoveCurrencyClick(object sender, RoutedEventArgs e)
        {
            CustomerGiven--;
            if (CustomerGiven < 0)
                CustomerGiven = 0;
        }
    }
}
