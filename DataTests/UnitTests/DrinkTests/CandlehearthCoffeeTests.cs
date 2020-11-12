/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(c);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var c = new CandlehearthCoffee();
            Assert.False(c.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var c = new CandlehearthCoffee();
            Assert.False(c.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var c = new CandlehearthCoffee();
            Assert.False(c.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var c = new CandlehearthCoffee();
            Assert.Equal(Size.Small, c.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var c = new CandlehearthCoffee();
            c.Ice = true;
            Assert.True(c.Ice);
            c.Ice = false;
            Assert.False(c.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var c = new CandlehearthCoffee();
            c.Decaf = true;
            Assert.True(c.Decaf);
            c.Decaf = false;
            Assert.False(c.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var c = new CandlehearthCoffee();
            c.RoomForCream = true;
            Assert.True(c.RoomForCream);
            c.RoomForCream = false;
            Assert.False(c.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var c = new CandlehearthCoffee();
            c.Size = Size.Large;
            Assert.Equal(Size.Large, c.Size);
            c.Size = Size.Medium;
            Assert.Equal(Size.Medium, c.Size);
            c.Size = Size.Small;
            Assert.Equal(Size.Small, c.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(price, c.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(cal, c.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var c = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };

            if (includeIce)
                Assert.Contains("Add ice", c.SpecialInstructions);
            if (includeCream)
                Assert.Contains("Add cream", c.SpecialInstructions);
            if (!includeCream && !includeIce)
                Assert.Empty(c.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            var c = new CandlehearthCoffee()
            {
                Decaf = decaf,
                Size = size
            };

            Assert.Equal(name, c.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var c = new CandlehearthCoffee();
            Assert.Equal("Candlehearth Coffee", c.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var c = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", c.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyWhenSettingSize(Size size)
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Size), () => {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangedWhenSizeChanged(Size size)
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Price), () => {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangedWhenSizeChanged(Size size)
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Calories), () => {
                c.Size = size;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingIce()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Ice), () => {
                c.Ice = true;
            });
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Ice), () => {
                c.Ice = false;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingRoomForCream()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.RoomForCream), () => {
                c.RoomForCream = true;
            });
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.RoomForCream), () => {
                c.RoomForCream = false;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingDecaf()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Decaf), () => {
                c.Decaf = true;
            });
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.Decaf), () => {
                c.Decaf = false;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.SpecialInstructions), () => {
                c.Ice = true;
            });
            Assert.PropertyChanged(c, nameof(CandlehearthCoffee.SpecialInstructions), () => {
                c.RoomForCream = true;
            });
        }
    }
}
