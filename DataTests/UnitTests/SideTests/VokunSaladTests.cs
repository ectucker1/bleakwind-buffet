﻿/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var vs = new VokunSalad();
            Assert.Equal("Vokun Salad", vs.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var vs = new VokunSalad();
            Assert.Equal("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.", vs.Description);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyPriceChangeWhenSizeChanged(Size size)
        {
            var vs = new VokunSalad();
            Assert.PropertyChanged(vs, nameof(VokunSalad.Price), () => {
                vs.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldNotifyCaloriesChangeWhenSizeChanged(Size size)
        {
            var vs = new VokunSalad();
            Assert.PropertyChanged(vs, nameof(VokunSalad.Calories), () => {
                vs.Size = size;
            });
        }
    }
}