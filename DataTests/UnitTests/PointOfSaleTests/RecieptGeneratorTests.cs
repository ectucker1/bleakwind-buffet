using Xunit;

using BleakwindBuffet.PointOfSale.Controls.Payment;
using System.Windows.Documents;
using System.Collections.Generic;
using BleakwindBuffet.Data;
using BleakwindBuffet.DataTests.UnitTests.MockData;

/*
 * Author: Ethan Tucker
 * Class: MenuTests.cs
 * Purpose: Test the RecieptGenerator.cs class in the Point of Sale
 */
namespace BleakwindBuffet.DataTests.UnitTests.PointOfSaleTests
{
    public class RecieptGeneratorTests
    {
        [Fact]
        public void ShouldCorrectlyWrapLines()
        {
            string[] wrapped = RecieptGenerator.WrapLine("small line");
            Assert.Collection(wrapped,
                item => Assert.Equal("small line", item)
            );
            wrapped = RecieptGenerator.WrapLine("---- line of exactly 40 characters ----");
            Assert.Collection(wrapped,
                item => Assert.Equal("---- line of exactly 40 characters ----", item)
            );
            wrapped = RecieptGenerator.WrapLine("line which is over forty characters long and should thus wrap");
            Assert.Collection(wrapped,
                item => Assert.Equal("line which is over forty characters long", item),
                item => Assert.Equal(" and should thus wrap", item)
            );
        }

        [Fact]
        public void ShouldCorrectlyAddWrappedLinesToReciept()
        {
            var reciept = new List<string>();
            RecieptGenerator.AddWrappedLine(reciept, "---- line of exactly 40 characters ----");
            RecieptGenerator.AddWrappedLine(reciept, "line which is over forty characters long and should thus wrap");
            Assert.Collection(reciept,
                item => Assert.Equal("---- line of exactly 40 characters ----", item),
                item => Assert.Equal("line which is over forty characters long", item),
                item => Assert.Equal(" and should thus wrap", item)
            );
        }

        [Fact]
        public void ShouldCorrectlyGenerateReciept()
        {
            var order = new Order();
            var entree = new MockEntree(5.00, 100);
            var drink = new MockDrink(1.00, 600);
            drink.AddInstruction("Hold ice");
            order.Add(entree);
            order.Add(drink);

            // Card paid reciept
            var reciept = RecieptGenerator.GenerateReciept(order, false);
            Assert.Collection(reciept,
                item => Assert.Contains("Order ", item),
                item => Assert.Contains("Submitted at ", item),
                item => Assert.Equal("Mock Entree - $5.00", item),
                item => Assert.Equal("Mock Drink - $1.00", item),
                item => Assert.Equal("Hold ice", item),
                item => Assert.Equal("Subtotal: $6.00", item),
                item => Assert.Equal("Tax: $0.72", item),
                item => Assert.Equal("Total: $6.72", item),
                item => Assert.Equal("Paid with card", item)
            );

            // Cash paid reciept
            reciept = RecieptGenerator.GenerateReciept(order, true, 2.00);
            Assert.Collection(reciept,
                item => Assert.Contains("Order ", item),
                item => Assert.Contains("Submitted at ", item),
                item => Assert.Equal("Mock Entree - $5.00", item),
                item => Assert.Equal("Mock Drink - $1.00", item),
                item => Assert.Equal("Hold ice", item),
                item => Assert.Equal("Subtotal: $6.00", item),
                item => Assert.Equal("Tax: $0.72", item),
                item => Assert.Equal("Total: $6.72", item),
                item => Assert.Equal("Paid with cash", item),
                item => Assert.Equal("Change owed: $2.00", item)
            );
        }
    }
}
