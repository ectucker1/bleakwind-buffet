/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var m = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var m = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var m = new MarkarthMilk();
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var m = new MarkarthMilk();
            Assert.Equal(Size.Small, m.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var m = new MarkarthMilk();
            m.Ice = true;
            Assert.True(m.Ice);
            m.Ice = false;
            Assert.False(m.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var m = new MarkarthMilk();
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(cal, m.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var m = new MarkarthMilk();
            m.Ice = includeIce;

            if (includeIce)
                Assert.Contains("Add ice", m.SpecialInstructions);
            else
                Assert.Empty(m.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var m = new MarkarthMilk();
            Assert.Equal("Markarth Milk", m.BaseName);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyWhenSettingSize(Size size)
        {
            var m = new MarkarthMilk();
            Assert.PropertyChanged(m, nameof(MarkarthMilk.Size), () => {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangedWhenSizeChanged(Size size)
        {
            var m = new MarkarthMilk();
            Assert.PropertyChanged(m, nameof(MarkarthMilk.Price), () => {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangedWhenSizeChanged(Size size)
        {
            var m = new MarkarthMilk();
            Assert.PropertyChanged(m, nameof(MarkarthMilk.Calories), () => {
                m.Size = size;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingIce()
        {
            var m = new MarkarthMilk();
            Assert.PropertyChanged(m, nameof(MarkarthMilk.Ice), () => {
                m.Ice = true;
            });
            Assert.PropertyChanged(m, nameof(MarkarthMilk.Ice), () => {
                m.Ice = false;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var m = new MarkarthMilk();
            Assert.PropertyChanged(m, nameof(MarkarthMilk.SpecialInstructions), () => {
                m.Ice = true;
            });
        }
    }
}