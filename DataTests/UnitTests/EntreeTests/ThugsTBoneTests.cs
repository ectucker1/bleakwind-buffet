/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var tb = new ThugsTBone();
            Assert.Equal(982u, tb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }
    }
}