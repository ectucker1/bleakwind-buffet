/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var tt = new ThalmorTriple();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var tt = new ThalmorTriple();
            Assert.Equal(943u, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var tt = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };

            if (!includeBun)
                Assert.Contains("Hold bun", tt.SpecialInstructions);
            if (!includeKetchup)
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            if (!includeMustard)
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
            if (!includePickle)
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
            if (!includeCheese)
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
            if (!includeTomato)
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
            if (!includeLettuce)
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            if (!includeMayo)
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
            if (!includeBacon)
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
            if (!includeEgg)
                Assert.Contains("Hold egg", tt.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle&& includeCheese && includeTomato && includeLettuce && includeMayo && includeBacon && includeEgg)
                Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.BaseName);
        }

        [Fact]
        public void ShouldNotifyWhenSettingBun()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Bun), () => {
                tt.Bun = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Bun), () => {
                tt.Bun = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingKetchup()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Ketchup), () => {
                tt.Ketchup = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Ketchup), () => {
                tt.Ketchup = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMustard()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Mustard), () => {
                tt.Mustard = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Mustard), () => {
                tt.Mustard = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingPickle()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Pickle), () => {
                tt.Pickle = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Pickle), () => {
                tt.Pickle = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingCheese()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Cheese), () => {
                tt.Cheese = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Cheese), () => {
                tt.Cheese = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingTomato()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Tomato), () => {
                tt.Tomato = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Tomato), () => {
                tt.Tomato = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingLettuce()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Lettuce), () => {
                tt.Lettuce = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Lettuce), () => {
                tt.Lettuce = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMayo()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Mayo), () => {
                tt.Mayo = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Mayo), () => {
                tt.Mayo = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingBacon()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Bacon), () => {
                tt.Bacon = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Bacon), () => {
                tt.Bacon = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingEgg()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Egg), () => {
                tt.Egg = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.Egg), () => {
                tt.Egg = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Bun = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Ketchup = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Mustard = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Pickle = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Cheese = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Tomato = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Lettuce = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Mayo = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Bacon = false;
            });
            Assert.PropertyChanged(tt, nameof(ThalmorTriple.SpecialInstructions), () => {
                tt.Egg = false;
            });
        }
    }
}