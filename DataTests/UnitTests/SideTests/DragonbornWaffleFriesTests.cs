﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(wf);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var wf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(wf);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var wf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, wf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var wf = new DragonbornWaffleFries();
            wf.Size = Size.Large;
            Assert.Equal(Size.Large, wf.Size);
            wf.Size = Size.Medium;
            Assert.Equal(Size.Medium, wf.Size);
            wf.Size = Size.Small;
            Assert.Equal(Size.Small, wf.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var wf = new DragonbornWaffleFries();
            Assert.Empty(wf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(price, wf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(calories, wf.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var wf = new DragonbornWaffleFries();
            wf.Size = size;
            Assert.Equal(name, wf.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var wf = new DragonbornWaffleFries();
            Assert.Equal("Dragonborn Waffle Fries", wf.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var wf = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", wf.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangeWhenSizeChanged(Size size)
        {
            var wf = new DragonbornWaffleFries();
            Assert.PropertyChanged(wf, nameof(DragonbornWaffleFries.Price), () => {
                wf.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangeWhenSizeChanged(Size size)
        {
            var wf = new DragonbornWaffleFries();
            Assert.PropertyChanged(wf, nameof(DragonbornWaffleFries.Calories), () => {
                wf.Size = size;
            });
        }
    }
}