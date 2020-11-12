/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var tb = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tb);
        }

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

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var tt = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", tt.Description);
        }
    }
}