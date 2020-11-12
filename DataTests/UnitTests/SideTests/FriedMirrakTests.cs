/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(fm);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var fm = new FriedMiraak();
            Assert.Equal("Fried Miraak", fm.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var fm = new FriedMiraak();
            Assert.Equal("Perfectly prepared hash brown pancakes.", fm.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangeWhenSizeChanged(Size size)
        {
            var fm = new FriedMiraak();
            Assert.PropertyChanged(fm, nameof(FriedMiraak.Price), () => {
                fm.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangeWhenSizeChanged(Size size)
        {
            var fm = new FriedMiraak();
            Assert.PropertyChanged(fm, nameof(FriedMiraak.Calories), () => {
                fm.Size = size;
            });
        }
    }
}