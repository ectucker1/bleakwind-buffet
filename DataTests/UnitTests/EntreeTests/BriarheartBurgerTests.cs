/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var bb = new BriarheartBurger();
            Assert.Equal(743u, bb.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            var bb = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
            };

            if (!includeBun)
                Assert.Contains("Hold bun", bb.SpecialInstructions);
            if (!includeKetchup)
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            if (!includeMustard)
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
            if (!includePickle)
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
            if (!includeCheese)
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese)
                Assert.Empty(bb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var bb = new BriarheartBurger();
            Assert.Equal("Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.", bb.Description);
        }

        [Fact]
        public void ShouldNotifyWhenSettingBun()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Bun), () => {
                bb.Bun = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Bun), () => {
                bb.Bun = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingKetchup()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Ketchup), () => {
                bb.Ketchup = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Ketchup), () => {
                bb.Ketchup = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMustard()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Mustard), () => {
                bb.Mustard = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Mustard), () => {
                bb.Mustard = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingPickle()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Pickle), () => {
                bb.Pickle = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Pickle), () => {
                bb.Pickle = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingCheese()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Cheese), () => {
                bb.Cheese = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.Cheese), () => {
                bb.Cheese = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var bb = new BriarheartBurger();
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.SpecialInstructions), () => {
                bb.Bun = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.SpecialInstructions), () => {
                bb.Ketchup = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.SpecialInstructions), () => {
                bb.Mustard = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.SpecialInstructions), () => {
                bb.Pickle = false;
            });
            Assert.PropertyChanged(bb, nameof(BriarheartBurger.SpecialInstructions), () => {
                bb.Cheese = false;
            });
        }
    }
}