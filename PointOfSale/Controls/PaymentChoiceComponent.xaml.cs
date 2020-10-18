using RoundRegister;
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
 * Class name: PaymentChoiceComponent.xaml.cs
 * Purpose: Define the PaymentChoiceComponent
 */
namespace BleakwindBuffet.PointOfSale.Controls
{
    /// <summary>
    /// Interaction logic for PaymentChoiceComponent.xaml
    /// </summary>
    public partial class PaymentChoiceComponent : UserControl
    {
        public PaymentChoiceComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hides the cash payment control, and shows the button options
        /// </summary>
        public void Reset()
        {
            buttonCashPayment.Visibility = Visibility.Visible;
            buttonCreditPayment.Visibility = Visibility.Visible;
            controlCashPayment.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Shows the cash payment screen when the Cash button is pressed
        /// </summary>
        /// <param name="sender">The cash button</param>
        /// <param name="e">Click event arguments</param>
        private void HandleCashPayment(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            buttonCashPayment.Visibility = Visibility.Collapsed;
            buttonCreditPayment.Visibility = Visibility.Collapsed;
            controlCashPayment.SetCharge(orderComponent.Order.Total);
            controlCashPayment.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles credit card payment when the Credit/Debit button is pressed
        /// </summary>
        /// <param name="sender">The Credit/Debit button</param>
        /// <param name="e">Click event arguments</param>
        private void HandleCreditPayment(object sender, RoutedEventArgs e)
        {
            var orderComponent = this.FindAncestor<OrderComponent>();
            var result = CardReader.RunCard(orderComponent.Order.Total);
            switch (result)
            {
                case CardTransactionResult.Declined:
                    MessageBox.Show("Card declined.");
                    break;
                case CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect PIN entered.");
                    break;
                case CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Insufficient funds on card.");
                    break;
                case CardTransactionResult.ReadError:
                    MessageBox.Show("Error reading card.");
                    break;
                case CardTransactionResult.Approved:
                    orderComponent.FinishPayment();
                    break;
            }
        }
    }
}
