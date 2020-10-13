/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var og = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(og);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var og = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(og);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var og = new MadOtarGrits();
            Assert.Equal(Size.Small, og.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var og = new MadOtarGrits();
            og.Size = Size.Large;
            Assert.Equal(Size.Large, og.Size);
            og.Size = Size.Medium;
            Assert.Equal(Size.Medium, og.Size);
            og.Size = Size.Small;
            Assert.Equal(Size.Small, og.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var og = new MadOtarGrits();
            Assert.Empty(og.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(price, og.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(calories, og.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var og = new MadOtarGrits();
            og.Size = size;
            Assert.Equal(name, og.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var og = new MadOtarGrits();
            Assert.Equal("Mad Otar Grits", og.BaseName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangeWhenSizeChanged(Size size)
        {
            var og = new MadOtarGrits();
            Assert.PropertyChanged(og, nameof(MadOtarGrits.Price), () => {
                og.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangeWhenSizeChanged(Size size)
        {
            var og = new MadOtarGrits();
            Assert.PropertyChanged(og, nameof(MadOtarGrits.Calories), () => {
                og.Size = size;
            });
        }
    }
}