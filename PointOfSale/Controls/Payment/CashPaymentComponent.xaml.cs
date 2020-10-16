using PointOfSale.Controls.Payment;
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
 * Class name: CashPaymentComponent.xaml.cs
 * Purpose: Handles all the inputs needed for cash payments
 */
namespace BleakwindBuffet.PointOfSale.Controls.Payment
{
    /// <summary>
    /// Interaction logic for CashPaymentComponent.xaml
    /// </summary>
    public partial class CashPaymentComponent : UserControl
    {
        /// <summary>
        /// Creates a new CashPaymentComponent and initializes its view model
        /// </summary>
        public CashPaymentComponent()
        {
            InitializeComponent();
            DataContext = new CashPaymentViewModel();
        }

        /// <summary>
        /// Sets the total charge and resets the values of the viewmodel
        /// </summary>
        /// <param name="charge">The total charge being paid for</param>
        public void SetCharge(double charge)
        {
            var vm = new CashPaymentViewModel();
            vm.TotalSale = charge;
            DataContext = vm;
        }
    }
}
