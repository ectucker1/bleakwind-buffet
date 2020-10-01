/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var aj = new AretinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce)
                Assert.Contains("Add ice", aj.SpecialInstructions);
            else
                Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }


        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyWhenSettingSize(Size size)
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.Size), () => {
                aj.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangedWhenSizeChanged(Size size)
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.Price), () => {
                aj.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangedWhenSizeChanged(Size size)
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.Calories), () => {
                aj.Size = size;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingIce()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.Ice), () => {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.Ice), () => {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var aj = new AretinoAppleJuice();
            Assert.PropertyChanged(aj, nameof(AretinoAppleJuice.SpecialInstructions), () => {
                aj.Ice = true;
            });
        }
    }
}