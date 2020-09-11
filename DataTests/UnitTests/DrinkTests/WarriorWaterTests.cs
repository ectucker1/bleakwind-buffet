/*
 * Author: Ethan Tucker
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            var w = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(w);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var w = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(w);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var w = new WarriorWater();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            var w = new WarriorWater();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var w = new WarriorWater();
            w.Ice = false;
            Assert.False(w.Ice);
            w.Ice = true;
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var w = new WarriorWater();
            w.Lemon = true;
            Assert.True(w.Lemon);
            w.Lemon = false;
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var w = new WarriorWater();
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Small;
            Assert.Equal(Size.Small, w.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var w = new WarriorWater();
            w.Size = size;
            Assert.Equal(price, w.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var w = new WarriorWater();
            w.Size = size;
            Assert.Equal(cal, w.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var w = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };

            if (!includeIce)
                Assert.Contains("Hold ice", w.SpecialInstructions);
            if (includeLemon)
                Assert.Contains("Add lemon", w.SpecialInstructions);
            if (includeIce && !includeLemon)
                Assert.Empty(w.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var w = new WarriorWater();
            w.Size = size;
            Assert.Equal(name, w.ToString());
        }
    }
}
