/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var dd = new DoubleDraugr();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var dd = new DoubleDraugr();
            Assert.Equal(843u, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            var dd = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
            };

            if (!includeBun)
                Assert.Contains("Hold bun", dd.SpecialInstructions);
            if (!includeKetchup)
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            if (!includeMustard)
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
            if (!includePickle)
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
            if (!includeCheese)
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
            if (!includeTomato)
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
            if (!includeLettuce)
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            if (!includeMayo)
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeLettuce && includeMayo)
                Assert.Empty(dd.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var dd = new DoubleDraugr();
            Assert.Equal("Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.",
                dd.Description);
        }

        [Fact]
        public void ShouldNotifyWhenSettingBun()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Bun), () => {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Bun), () => {
                dd.Bun = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingKetchup()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Ketchup), () => {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Ketchup), () => {
                dd.Ketchup = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMustard()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Mustard), () => {
                dd.Mustard = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Mustard), () => {
                dd.Mustard = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingPickle()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Pickle), () => {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Pickle), () => {
                dd.Pickle = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingCheese()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Cheese), () => {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Cheese), () => {
                dd.Cheese = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingTomato()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Tomato), () => {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Tomato), () => {
                dd.Tomato = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingLettuce()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Lettuce), () => {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Lettuce), () => {
                dd.Lettuce = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMayo()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Mayo), () => {
                dd.Mayo = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.Mayo), () => {
                dd.Mayo = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Mustard = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, nameof(DoubleDraugr.SpecialInstructions), () => {
                dd.Mayo = false;
            });
        }
    }
}