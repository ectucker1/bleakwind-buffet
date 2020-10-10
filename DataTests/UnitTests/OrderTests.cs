using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.DataTests.UnitTests.MockData;
using System.Collections;
using System.Collections.Specialized;
using System;
using System.Linq;

/*
 * Author: Ethan Tucker
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldImplementICollection()
        {
            var o = new Order();
            Assert.IsAssignableFrom<ICollection>(o);
        }

        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        [Fact]
        public void CanSetSalesTaxRate()
        {
            var o = new Order();
            o.SalesTaxRate = 0.5;
            Assert.Equal(0.5, o.SalesTaxRate);
        }

        [Theory]
        [InlineData(1.00, 2.00, 3.00)]
        [InlineData(5.00, 3.00, 8.00)]
        public void ShouldAddPricesForSubtotal(double price1, double price2, double subotal)
        {
            var o = new Order();
            Assert.Equal(0, o.Subtotal);
            o.Add(new MockEntree(price1, 0));
            o.Add(new MockEntree(price2, 0));
            Assert.Equal(subotal, o.Subtotal);
        }

        [Theory]
        [InlineData(1.00, 2.00, 0.36)]
        [InlineData(5.00, 3.00, 0.96)]
        public void ShouldMultiplySubtotalForTax(double price1, double price2, double tax)
        {
            var o = new Order();
            Assert.Equal(0, o.Tax);
            o.Add(new MockEntree(price1, 0));
            o.Add(new MockEntree(price2, 0));
            Assert.Equal(tax, o.Tax);
        }

        [Theory]
        [InlineData(1.00, 2.00, 3.36)]
        [InlineData(5.00, 3.00, 8.96)]
        public void ShouldAddSubtotalAndTaxForTotal(double price1, double price2, double total)
        {
            var o = new Order();
            Assert.Equal(0, o.Total);
            o.Add(new MockEntree(price1, 0));
            o.Add(new MockEntree(price2, 0));
            Assert.Equal(total, o.Total);
        }

        [Theory]
        [InlineData(100, 200, 300)]
        [InlineData(500, 400, 900)]
        public void ShouldAddCalories(uint calories1, uint calories2, uint totalCalories)
        {
            var o = new Order();
            Assert.Equal(0u, o.Calories);
            o.Add(new MockEntree(0, calories1));
            o.Add(new MockEntree(0, calories2));
            Assert.Equal(totalCalories, o.Calories);
        }

        [Fact]
        public void ShouldAssignNumbersSequentially()
        {
            var o1 = new Order();
            var o2 = new Order();
            var o3 = new Order();
            Assert.Equal(o1.Number + 1, o2.Number);
            Assert.Equal(o1.Number + 2, o3.Number);
        }

        // TODO Test INotifyCollectionChanged events here

        [Fact]
        public void ShouldNotifyPropertiesChangedWhenItemAdded()
        {
            var o = new Order();
            Assert.PropertyChanged(o, nameof(Order.Subtotal), () =>
            {
                o.Add(new MockEntree(0, 0));
            });
            Assert.PropertyChanged(o, nameof(Order.Tax), () =>
            {
                o.Add(new MockEntree(0, 0));
            });
            Assert.PropertyChanged(o, nameof(Order.Total), () =>
            {
                o.Add(new MockEntree(0, 0));
            });
            Assert.PropertyChanged(o, nameof(Order.Calories), () =>
            {
                o.Add(new MockEntree(0, 0));
            });
        }

        [Fact]
        public void ShouldNotifyPropertiesChangedWhenItemRemoved()
        {
            var e1 = new MockEntree(0, 0);
            var e2 = new MockEntree(0, 0);
            var e3 = new MockEntree(0, 0);
            var e4 = new MockEntree(0, 0);
            var o = new Order();
            o.Add(e1);
            o.Add(e2);
            o.Add(e3);
            o.Add(e4);
            Assert.PropertyChanged(o, nameof(Order.Subtotal), () =>
            {
                o.Remove(e1);
            });
            Assert.PropertyChanged(o, nameof(Order.Tax), () =>
            {
                o.Remove(e2);
            });
            Assert.PropertyChanged(o, nameof(Order.Total), () =>
            {
                o.Remove(e3);
            });
            Assert.PropertyChanged(o, nameof(Order.Calories), () =>
            {
                o.Remove(e4);
            });
        }

        [Fact]
        public void ShouldNotifyTotalsChangedWhenItemPriceChanged()
        {
            var o = new Order();
            var e = new MockEntree(0, 0);
            o.Add(e);
            Assert.PropertyChanged(o, nameof(Order.Subtotal), () =>
            {
                e.SetPrice(1.00);
            });
            Assert.PropertyChanged(o, nameof(Order.Tax), () =>
            {
                e.SetPrice(1.00);
            });
            Assert.PropertyChanged(o, nameof(Order.Total), () =>
            {
                e.SetPrice(1.00);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenItemCaloriesChanged()
        {
            var o = new Order();
            var e = new MockEntree(0, 0);
            o.Add(e);
            Assert.PropertyChanged(o, nameof(Order.Calories), () =>
            {
                e.SetCalories(100);
            });
        }

        [Fact]
        public void ShouldNotifyTotalsChangedWhenSalesTaxRateChanged()
        {
            var o = new Order();
            Assert.PropertyChanged(o, nameof(Order.Subtotal), () =>
            {
                o.SalesTaxRate = 0.5;
            });
            Assert.PropertyChanged(o, nameof(Order.Tax), () =>
            {
                o.SalesTaxRate = 0.5;
            });
            Assert.PropertyChanged(o, nameof(Order.Total), () =>
            {
                o.SalesTaxRate = 0.5;
            });
        }
    }
}
