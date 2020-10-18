using Xunit;

using BleakwindBuffet.PointOfSale.Controls.Payment;
using System;
using RoundRegister;
using PointOfSale.Controls.Payment;
using System.ComponentModel;

/*
 * Author: Ethan Tucker
 * Class: CashPaymentViewModelTests.cs
 * Purpose: Test the CashPaymentViewModel.cs class in the Point of Sale
 */
namespace BleakwindBuffet.DataTests.UnitTests.PointOfSaleTests
{
    public class CashPaymentViewModelTests : IDisposable
    {
        CashPaymentViewModel model;

        public CashPaymentViewModelTests()
        {
            // Initialize the model for each test
            model = new CashPaymentViewModel();
            CashDrawer.ResetDrawer();
        }

        public void Dispose()
        {
            // Reset the cash drawer between each test
            // Initial values are:
            // 5 twenties
            // 10 tens
            // 4 fives
            // 20 ones
            // 80 quarters
            // 100 dimes
            // 80 nickels
            // 200 pennies
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(model);
        }

        [Fact]
        public void ShouldDefaultToNothingPaid()
        {
            Assert.Equal(0, model.HundredsGiven);
            Assert.Equal(0, model.FiftiesGiven);
            Assert.Equal(0, model.TwentiesGiven);
            Assert.Equal(0, model.TensGiven);
            Assert.Equal(0, model.FivesGiven);
            Assert.Equal(0, model.TwosGiven);
            Assert.Equal(0, model.OnesGiven);
            Assert.Equal(0, model.DollarsGiven);
            Assert.Equal(0, model.HalfDollarsGiven);
            Assert.Equal(0, model.QuartersGiven);
            Assert.Equal(0, model.DimesGiven);
            Assert.Equal(0, model.NickelsGiven);
            Assert.Equal(0, model.PenniesGiven);
            Assert.Equal(0, model.AmountPaid);
        }

        [Fact]
        public void ShouldDefaultToNoPrice()
        {
            Assert.Equal(0, model.TotalSale);
            Assert.Equal(0, model.AmountDue);
        }

        [Fact]
        public void ShouldBeAbleToSetTotalSale()
        {
            model.TotalSale = 10.00;
            Assert.Equal(10.00, model.TotalSale);
        }

        [Fact]
        public void ShouldBeAbleToSetCurrenciesGiven()
        {
            model.HundredsGiven = 2;
            Assert.Equal(2, model.HundredsGiven);
            model.FiftiesGiven = 2;
            Assert.Equal(2, model.FiftiesGiven);
            model.TwentiesGiven = 2;
            Assert.Equal(2, model.TwentiesGiven);
            model.TensGiven = 2;
            Assert.Equal(2, model.TensGiven);
            model.FivesGiven = 2;
            Assert.Equal(2, model.FivesGiven);
            model.TwosGiven = 2;
            Assert.Equal(2, model.TwosGiven);
            model.OnesGiven = 2;
            Assert.Equal(2, model.OnesGiven);
            model.DollarsGiven = 2;
            Assert.Equal(2, model.DollarsGiven);
            model.HalfDollarsGiven = 2;
            Assert.Equal(2, model.HalfDollarsGiven);
            model.QuartersGiven = 2;
            Assert.Equal(2, model.QuartersGiven);
            model.DimesGiven = 2;
            Assert.Equal(2, model.DimesGiven);
            model.NickelsGiven = 2;
            Assert.Equal(2, model.NickelsGiven);
            model.PenniesGiven = 2;
            Assert.Equal(2, model.PenniesGiven);
        }

        [Fact]
        public void ShouldCalculateCorrectAmountPaid()
        {
            model.HundredsGiven = 2;
            Assert.Equal(200.00, model.AmountPaid);
            model.FiftiesGiven = 2;
            Assert.Equal(300.00, model.AmountPaid);
            model.TwentiesGiven = 2;
            Assert.Equal(340.00, model.AmountPaid);
            model.TensGiven = 2;
            Assert.Equal(360.00, model.AmountPaid);
            model.FivesGiven = 2;
            Assert.Equal(370.00, model.AmountPaid);
            model.TwosGiven = 2;
            Assert.Equal(374.00, model.AmountPaid);
            model.OnesGiven = 2;
            Assert.Equal(376.00, model.AmountPaid);
            model.DollarsGiven = 2;
            Assert.Equal(378.00, model.AmountPaid);
            model.HalfDollarsGiven = 2;
            Assert.Equal(379.00, model.AmountPaid);
            model.QuartersGiven = 2;
            Assert.Equal(379.50, model.AmountPaid);
            model.DimesGiven = 2;
            Assert.Equal(379.70, model.AmountPaid);
            model.NickelsGiven = 2;
            Assert.Equal(379.80, model.AmountPaid);
            model.PenniesGiven = 2;
            Assert.Equal(379.82, model.AmountPaid);
        }

        [Theory]
        [InlineData(100.00, 0.00)]
        [InlineData(0.00, 0.00)]
        [InlineData(50.00, 0.00)]
        [InlineData(200.00, 100.00)]
        [InlineData(250.00, 150.00)]
        public void ShouldCalculateCorrectAmountDue(double totalSale, double amountDue)
        {
            model.HundredsGiven = 1;
            model.TotalSale = totalSale;
            Assert.Equal(model.AmountDue, amountDue);
        }

        [Theory]
        [InlineData(100.00, 0.00)]
        [InlineData(150.00, 0.00)]
        [InlineData(250.00, 0.00)]
        [InlineData(75.00, 25.00)]
        [InlineData(25.00, 75.00)]
        [InlineData(0.00, 100.00)]
        public void ShouldCalculateCorrectChangeDue(double totalSale, double changeDue)
        {
            model.HundredsGiven = 1;
            model.TotalSale = totalSale;
            Assert.Equal(model.ChangeDue, changeDue);
        }

        [Theory]
        [InlineData(100.00, true)]
        [InlineData(100.01, false)]
        [InlineData(75.00, true)]
        [InlineData(150.00, false)]
        public void ShouldDetermineIfPaymentValid(double totalSale, bool paymentValid)
        {
            model.HundredsGiven = 1;
            model.TotalSale = totalSale;
            Assert.Equal(model.PaymentValid, paymentValid);
        }

        [Fact]
        public void ShouldMakeCorrectChange()
        {
            model.HundredsGiven = 1;
            model.TensGiven = 1;
            model.DollarsGiven = 5;
            model.NickelsGiven = 2;
            model.PenniesGiven = 4;
            Assert.Equal(5, model.TwentiesChange);
            Assert.Equal(1, model.TensChange);
            Assert.Equal(1, model.FivesChange);
            Assert.Equal(1, model.DimesChange);
            Assert.Equal(4, model.PenniesChange);
        }

        [Fact]
        public void ShouldCorrectlyApplySaleToDrawer()
        {
            model.HundredsGiven = 1;
            model.TensGiven = 1;
            model.DollarsGiven = 5;
            model.NickelsGiven = 2;
            model.PenniesGiven = 4;
            // Will result in change of:
            // 5 twenties
            // 1 ten
            // 1 five
            // 1 dime
            // 4 pennies
            model.ApplyCashSale();
            Assert.Equal(1, CashDrawer.Hundreds);
            Assert.Equal(0, CashDrawer.Fifties);
            Assert.Equal(0, CashDrawer.Twenties);
            Assert.Equal(10, CashDrawer.Tens);
            Assert.Equal(3, CashDrawer.Fives);
            Assert.Equal(0, CashDrawer.Twos);
            Assert.Equal(20, CashDrawer.Ones);
            Assert.Equal(5, CashDrawer.Dollars);
            Assert.Equal(0, CashDrawer.HalfDollars);
            Assert.Equal(80, CashDrawer.Quarters);
            Assert.Equal(99, CashDrawer.Dimes);
            Assert.Equal(82, CashDrawer.Nickels);
            Assert.Equal(200, CashDrawer.Pennies);
        }

        [Fact]
        public void ShouldNotifyPropertiesChangedWhenTotalSaleChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.TotalSale), () =>
            {
                model.TotalSale = 10.00;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.TotalSale = 10.00;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.TotalSale = 10.00;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.TotalSale = 10.00;
            });
        }

        [Fact]
        public void ShouldNotifyWhenCurrencyGivenChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.HundredsGiven), () =>
            {
                model.HundredsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.FiftiesGiven), () =>
            {
                model.FiftiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.TwentiesGiven), () =>
            {
                model.TwentiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.TensGiven), () =>
            {
                model.TensGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.FivesGiven), () =>
            {
                model.FivesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.TwosGiven), () =>
            {
                model.TwosGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.OnesGiven), () =>
            {
                model.OnesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.DollarsGiven), () =>
            {
                model.DollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.HalfDollarsGiven), () =>
            {
                model.HalfDollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.QuartersGiven), () =>
            {
                model.QuartersGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.DimesGiven), () =>
            {
                model.DimesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.NickelsGiven), () =>
            {
                model.NickelsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PenniesGiven), () =>
            {
                model.PenniesGiven = 1;
            });
        }

        [Fact]
        public void ShouldNotifyAmountPaidChangedWhenCurrencyGivenChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.HundredsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.FiftiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.TwentiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.TensGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.FivesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.TwosGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.OnesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.DollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.HalfDollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.QuartersGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.DimesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.NickelsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountPaid), () =>
            {
                model.PenniesGiven = 1;
            });
        }

        [Fact]
        public void ShouldNotifyAmountDueChangedWhenCurrencyGivenChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.HundredsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.FiftiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.TwentiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.TensGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.FivesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.TwosGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.OnesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.DollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.HalfDollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.QuartersGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.DimesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.NickelsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.AmountDue), () =>
            {
                model.PenniesGiven = 1;
            });
        }

        [Fact]
        public void ShouldNotifyChangeDueChangedWhenCurrencyGivenChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.HundredsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.FiftiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.TwentiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.TensGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.FivesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.TwosGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.OnesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.DollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.HalfDollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.QuartersGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.DimesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.NickelsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.ChangeDue), () =>
            {
                model.PenniesGiven = 1;
            });
        }

        [Fact]
        public void ShouldNotifyPaymentValidChangedWhenCurrencyGivenChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.HundredsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.FiftiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.TwentiesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.TensGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.FivesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.TwosGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.OnesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.DollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.HalfDollarsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.QuartersGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.DimesGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.NickelsGiven = 1;
            });
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.PaymentValid), () =>
            {
                model.PenniesGiven = 1;
            });
        }

        [Fact]
        public void ShouldRecalculateChangeWhenAmountPaidChanged()
        {
            Assert.PropertyChanged(model, nameof(CashPaymentViewModel.HundredsChange), () =>
            {
                model.HundredsGiven = 1;
            });
        }
    }
}
