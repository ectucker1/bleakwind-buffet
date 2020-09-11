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
    }
}
