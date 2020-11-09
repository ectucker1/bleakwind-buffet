/*
 * Author: Ethan Tucker
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using System.Windows.Documents;
using BleakwindBuffet.DataTests.UnitTests.MockData;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldReturnCorrectEntreeList()
        {
            var entrees = Menu.Entrees();
            // Run an assertion lambda for each entree
            Assert.Collection(entrees,
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThugsTBone>(item)
            );
        }

        [Fact]
        public void ShouldReturnCorrectSideList()
        {
            var sides = Menu.Sides();
            // Run an assertion lambda for each side
            Assert.Collection(sides,
                /* Small Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                /* Medium Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                /* Large Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                }
            );
        }

        [Fact]
        public void ShouldReturnCorrectPlainSideList()
        {
            var sides = Menu.PlainSides();
            // Run an assertion lambda for each side
            Assert.Collection(sides,
                item => Assert.IsType<VokunSalad>(item),
                item => Assert.IsType<FriedMiraak>(item),
                item => Assert.IsType<MadOtarGrits>(item),
                item => Assert.IsType<DragonbornWaffleFries>(item)
            );
        }

        [Fact]
        public void ShouldReturnCorrectDrinkList()
        {
            var drinks = Menu.Drinks();
            // Run an assertion lambda for each drink
            Assert.Collection(drinks,
                /* Small Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                /* Medium Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                /* Large Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                }
            );
        }

        [Fact]
        public void ShouldReturnCorrectPlainDrinkList()
        {
            var drinks = Menu.PlainDrinks();
            // Run an assertion lambda for each drink
            Assert.Collection(drinks,
                item => Assert.IsType<AretinoAppleJuice>(item),
                item => Assert.IsType<CandlehearthCoffee>(item),
                item => Assert.IsType<MarkarthMilk>(item),
                item => Assert.IsType<WarriorWater>(item),
                item => Assert.IsType<SailorSoda>(item)
            );
        }

        [Fact]
        public void ShouldReturnCorrectFullMenu()
        {
            var items = Menu.FullMenu();
            Assert.Collection(items,
                /* Entrees */
                item => Assert.IsType<BriarheartBurger>(item),
                item => Assert.IsType<DoubleDraugr>(item),
                item => Assert.IsType<ThalmorTriple>(item),
                item => Assert.IsType<GardenOrcOmelette>(item),
                item => Assert.IsType<PhillyPoacher>(item),
                item => Assert.IsType<SmokehouseSkeleton>(item),
                item => Assert.IsType<ThugsTBone>(item),
                /* Small Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Small, ((Side)item).Size);
                },
                /* Medium Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Medium, ((Side)item).Size);
                },
                /* Large Sides */
                item => {
                    Assert.IsType<VokunSalad>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<FriedMiraak>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<MadOtarGrits>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                item => {
                    Assert.IsType<DragonbornWaffleFries>(item);
                    Assert.Equal(Size.Large, ((Side)item).Size);
                },
                /* Small Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Small, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                /* Medium Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Medium, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                },
                /* Large Drinks */
                item => {
                    Assert.IsType<AretinoAppleJuice>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<CandlehearthCoffee>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<MarkarthMilk>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<WarriorWater>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Blackberry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Cherry, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Grapefruit, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Lemon, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Peach, ((SailorSoda)item).Flavor);
                },
                item => {
                    Assert.IsType<SailorSoda>(item);
                    Assert.Equal(Size.Large, ((Drink)item).Size);
                    Assert.Equal(SodaFlavor.Watermelon, ((SailorSoda)item).Flavor);
                }
            );
        }

        [Fact]
        public void ShouldCorrectlyFilterByType()
        {
            var items = new IOrderItem[] { new MockEntree(0, 0), new MockDrink(0, 0), new MockSide(0, 0) };
            // No types allowed
            var results = Menu.FilterByType(items, false, false, false);
            Assert.Empty(results);
            // Only entrees allowed
            results = Menu.FilterByType(items, true, false, false);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item));
            // Only sides allowed
            results = Menu.FilterByType(items, false, true, false);
            Assert.Collection(results, (item) => Assert.IsType<MockSide>(item));
            // Only drinks allowed
            results = Menu.FilterByType(items, false, false, true);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item));
            // All types allowed
            results = Menu.FilterByType(items, true, true, true);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByPriceWithNoBounds()
        {
            var items = new IOrderItem[] { new MockEntree(1, 0), new MockDrink(2, 0), new MockSide(3, 0) };
            var results = Menu.FilterByPrice(items, null, null);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByPriceWithLowerBound()
        {
            var items = new IOrderItem[] { new MockEntree(1, 0), new MockDrink(2, 0), new MockSide(3, 0) };
            var results = Menu.FilterByPrice(items, 2, null);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByPriceWithUpperBound()
        {
            var items = new IOrderItem[] { new MockEntree(1, 0), new MockDrink(2, 0), new MockSide(3, 0) };
            var results = Menu.FilterByPrice(items, null, 2);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByPriceWithBothBounds()
        {
            var items = new IOrderItem[] { new MockEntree(1, 0), new MockDrink(2, 0), new MockSide(3, 0) };
            var results = Menu.FilterByPrice(items, 1.1, 2.9);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByCaloriesWithNoBounds()
        {
            var items = new IOrderItem[] { new MockEntree(0, 10), new MockDrink(0, 20), new MockSide(0, 30) };
            var results = Menu.FilterByCalories(items, null, null);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByCaloriesWithLowerBound()
        {
            var items = new IOrderItem[] { new MockEntree(0, 10), new MockDrink(0, 20), new MockSide(0, 30) };
            var results = Menu.FilterByCalories(items, 20, null);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByCaloriesWithUpperBound()
        {
            var items = new IOrderItem[] { new MockEntree(0, 10), new MockDrink(0, 20), new MockSide(0, 30) };
            var results = Menu.FilterByCalories(items, null, 20);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterByCaloriesWithBothBounds()
        {
            var items = new IOrderItem[] { new MockEntree(0, 10), new MockDrink(0, 20), new MockSide(0, 30) };
            var results = Menu.FilterByCalories(items, 11, 29);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item));
        }

        [Fact]
        public void ShouldReturnFullListForNullSearch()
        {
            var items = new IOrderItem[] { new MockEntree(0, 0), new MockDrink(0, 0), new MockSide(0, 0) };
            var results = Menu.Search(items, null);
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterBySearch()
        {
            var items = new IOrderItem[] { new MockEntree(0, 0), new MockDrink(0, 0), new MockSide(0, 0) };
            var results = Menu.Search(items, "MOCK");
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
            results = Menu.Search(items, "mock");
            Assert.Collection(results, (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
            results = Menu.Search(items, "i");
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockSide>(item));
            results = Menu.Search(items, "DRinK");
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item));
        }

        [Fact]
        public void ShouldCorrectlyFilterDuplicates()
        {
            var items = new IOrderItem[] { new MockDrink(0, 0), new MockEntree(0, 0), new MockEntree(0, 0), new MockDrink(0, 0), new MockSide(0, 0), new MockDrink(0, 0) };
            var results = Menu.FilterDuplicates(items);
            Assert.Collection(results, (item) => Assert.IsType<MockDrink>(item),
                (item) => Assert.IsType<MockEntree>(item),
                (item) => Assert.IsType<MockSide>(item));
        }
    }
}
