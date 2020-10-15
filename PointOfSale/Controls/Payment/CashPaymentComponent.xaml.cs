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
        public CashPaymentComponent()
        {
            InitializeComponent();
            DataContext = new CashPaymentViewModel();
        }
    }
}
