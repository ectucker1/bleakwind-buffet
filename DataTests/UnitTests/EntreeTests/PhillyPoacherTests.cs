/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var pp = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var pp = new PhillyPoacher();
            Assert.Equal(784u, pp.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var pp = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };

            if (!includeSirloin)
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            if (!includeOnion)
                Assert.Contains("Hold onions", pp.SpecialInstructions);
            if (!includeRoll)
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            if (includeSirloin && includeOnion && includeRoll)
                Assert.Empty(pp.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.BaseName);
        }

        [Fact]
        public void ShouldNotifyWhenSettingSirloin()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Sirloin), () => {
                pp.Sirloin = false;
            });
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Sirloin), () => {
                pp.Sirloin = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingOnion()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Onion), () => {
                pp.Onion = false;
            });
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Onion), () => {
                pp.Onion = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingRoll()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Roll), () => {
                pp.Roll = false;
            });
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.Roll), () => {
                pp.Roll = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.SpecialInstructions), () => {
                pp.Sirloin = false;
            });
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.SpecialInstructions), () => {
                pp.Onion = false;
            });
            Assert.PropertyChanged(pp, nameof(PhillyPoacher.SpecialInstructions), () => {
                pp.Roll = false;
            });
        }
    }
}