/*
 * Author: Ethan Tucker
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using BleakwindBuffet.DataTests.UnitTests.MockData;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        [Fact]
        public void ShouldHaveBriarheartBurgerAsDefaultEntree()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<BriarheartBurger>(c.Entree);
        }

        [Fact]
        public void ShouldHaveDragonbornWaffleFriesAsDefaultSide()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<DragonbornWaffleFries>(c.Side);
        }

        [Fact]
        public void ShouldHaveSailorSodaAsDefaultDrink()
        {
            var c = new Combo();
            Assert.IsAssignableFrom<SailorSoda>(c.Drink);
        }

        [Fact]
        public void CanSetEntree()
        {
            var e = new MockEntree(0, 0);
            var c = new Combo();
            c.Entree = e;
            Assert.Equal(e, c.Entree);
        }

        [Fact]
        public void CanSetSide()
        {
            var s = new MockSide(0, 0);
            var c = new Combo();
            c.Side = s;
            Assert.Equal(s, c.Side);
        }

        [Fact]
        public void CanSetDrink()
        {
            var d = new MockDrink(0, 0);
            var c = new Combo();
            c.Drink = d;
            Assert.Equal(d, c.Drink);
        }

        [Fact]
        public void ReturnsCorrectToString()
        {
            var c = new Combo();
            Assert.Equal("Combo", c.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var c = new Combo();
            Assert.Equal("Combo", c.BaseName);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var c = new Combo();
            Assert.Equal("Combo of an Entree, Side, and Drink with a $1.00 discount.", c.Description);
        }

        [Theory]
        [InlineData(100, 200, 300, 600)]
        [InlineData(100, 100, 100, 300)]
        [InlineData(600, 500, 400, 1500)]
        public void ShouldSumToCalculateCalories(uint entreeCalories, uint sideCalories, uint drinkCalories, uint totalCalories)
        {
            var c = new Combo()
            {
                Entree = new MockEntree(0, entreeCalories),
                Side = new MockSide(0, sideCalories),
                Drink = new MockDrink(0, drinkCalories)
            };
            Assert.Equal(totalCalories, c.Calories);
        }

        [Theory]
        [InlineData(1.00, 2.00, 3.00, 5.00)]
        [InlineData(1.00, 1.00, 1.00, 2.00)]
        [InlineData(6.00, 5.00, 4.00, 14.00)]
        public void ShouldSumAndDiscountToCalculatePrice(double entreePrice, double sidePrice, double drinkPrice, double totalPrice)
        {
            var c = new Combo()
            {
                Entree = new MockEntree(entreePrice, 0),
                Side = new MockSide(sidePrice, 0),
                Drink = new MockDrink(drinkPrice, 0)
            };
            Assert.Equal(totalPrice, c.Price);
        }

        [Fact]
        public void ShouldCombineSpecialInstructions()
        {
            var e = new MockEntree(0, 0);
            e.AddInstruction("Entree instruction");
            var s = new MockSide(0, 0);
            s.AddInstruction("Side instruction");
            var d = new MockDrink(0, 0);
            d.AddInstruction("Drink instruction");
            var c = new Combo()
            {
                Entree = e,
                Side = s,
                Drink = d
            };
            Assert.Equal(6, c.SpecialInstructions.Count);
            Assert.Collection(c.SpecialInstructions,
                item => Assert.Equal("Mock Entree", item),
                item => Assert.Equal(" - Entree instruction", item),
                item => Assert.Equal("Mock Side", item),
                item => Assert.Equal(" - Side instruction", item),
                item => Assert.Equal("Mock Drink", item),
                item => Assert.Equal(" - Drink instruction", item)
            );
        }

        [Fact]
        public void ShouldNotifyWhenEntreeChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Entree), () =>
            {
                c.Entree = new MockEntree(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenEntreeChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                c.Entree = new MockEntree(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenEntreeChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                c.Entree = new MockEntree(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenEntreeChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.SpecialInstructions), () =>
            {
                c.Entree = new MockEntree(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyWhenSideChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Side), () =>
            {
                c.Side = new MockSide(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenSideChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                c.Side = new MockSide(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenSideChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                c.Side = new MockSide(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenSideChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.SpecialInstructions), () =>
            {
                c.Side = new MockSide(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyWhenDrinkChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Drink), () =>
            {
                c.Drink = new MockDrink(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenDrinkChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                c.Drink = new MockDrink(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenDrinkChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                c.Drink = new MockDrink(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenDrinkChanged()
        {
            var c = new Combo();
            Assert.PropertyChanged(c, nameof(Combo.Drink), () =>
            {
                c.Drink = new MockDrink(0, 0);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenEntreePriceChanged()
        {
            var c = new Combo();
            var e = new MockEntree(0, 0);
            c.Entree = e;
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                e.SetPrice(1.00);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenSidePriceChanged()
        {
            var c = new Combo();
            var s = new MockSide(0, 0);
            c.Side = s;
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                s.SetPrice(1.00);
            });
        }

        [Fact]
        public void ShouldNotifyPriceChangedWhenDrinkPriceChanged()
        {
            var c = new Combo();
            var d = new MockDrink(0, 0);
            c.Drink = d;
            Assert.PropertyChanged(c, nameof(Combo.Price), () =>
            {
                d.SetPrice(1.00);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenEntreeCaloriesChanged()
        {
            var c = new Combo();
            var e = new MockEntree(0, 0);
            c.Entree = e;
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                e.SetCalories(100);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenSideCaloriesChanged()
        {
            var c = new Combo();
            var s = new MockSide(0, 0);
            c.Side = s;
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                s.SetCalories(100);
            });
        }

        [Fact]
        public void ShouldNotifyCaloriesChangedWhenDrinkCaloriesChanged()
        {
            var c = new Combo();
            var d = new MockDrink(0, 0);
            c.Drink = d;
            Assert.PropertyChanged(c, nameof(Combo.Calories), () =>
            {
                d.SetCalories(100);
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenEntreeSpecialInstructionsChanged()
        {
            var c = new Combo();
            var e = new MockEntree(0, 0);
            c.Entree = e;
            Assert.PropertyChanged(c, nameof(Combo.SpecialInstructions), () =>
            {
                e.AddInstruction("Test");
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenSideSpecialInstructionsChanged()
        {
            var c = new Combo();
            var s = new MockSide(0, 0);
            c.Side = s;
            Assert.PropertyChanged(c, nameof(Combo.SpecialInstructions), () =>
            {
                s.AddInstruction("Test");
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChangedWhenDrinkSpecialInstructionsChanged()
        {
            var c = new Combo();
            var d = new MockDrink(0, 0);
            c.Drink = d;
            Assert.PropertyChanged(c, nameof(Combo.SpecialInstructions), () =>
            {
                d.AddInstruction("Test");
            });
        }
    }
}
