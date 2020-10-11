using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: Entree.cs
* Purpose: Static class used to list all menu items
*/
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Static class with methods used to list all menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all entrees on the menu
        /// </summary>
        /// <returns>A list of all entrees on the menu</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThugsTBone());
            return entrees;
        }

        /// <summary>
        /// Creates a list of all sides on the menu in every size
        /// </summary>
        /// <returns>A list of all sides on the menu</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            // Loop through each size by exploiting the fact that enums are integers
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                sides.Add(new VokunSalad()
                {
                    Size = size
                });
                sides.Add(new FriedMiraak()
                {
                    Size = size
                });
                sides.Add(new MadOtarGrits()
                {
                    Size = size
                });
                sides.Add(new DragonbornWaffleFries()
                {
                    Size = size
                });
            }
            return sides;
        }

        /// <summary>
        /// Creates a list of all sides on the menu in small
        /// </summary>
        /// <returns>A list of all sides on the menu</returns>
        public static IEnumerable<IOrderItem> PlainSides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new VokunSalad());
            sides.Add(new FriedMiraak());
            sides.Add(new MadOtarGrits());
            sides.Add(new DragonbornWaffleFries());
            return sides;
        }

        /// <summary>
        /// Creates a list of all drinks on the menu in every size and flavor
        /// </summary>
        /// <returns>A list of all drinks on the menu</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            // Loop through each size by exploiting the fact that enums are integers
            for (Size size = Size.Small; size <= Size.Large; size++)
            {
                drinks.Add(new AretinoAppleJuice()
                {
                    Size = size
                });
                drinks.Add(new CandlehearthCoffee()
                {
                    Size = size
                });
                drinks.Add(new MarkarthMilk()
                {
                    Size = size
                });
                drinks.Add(new WarriorWater()
                {
                    Size = size
                });
                // Loop through each soda flavor
                // Watermelon is the ultimate flavor and thus the highest
                for (SodaFlavor flavor = SodaFlavor.Blackberry; flavor <= SodaFlavor.Watermelon; flavor++)
                {
                    drinks.Add(new SailorSoda()
                    {
                        Size = size,
                        Flavor = flavor
                    });
                }
            }
            return drinks;
        }

        /// <summary>
        /// Creates a list of all drinks on the menu in small
        /// </summary>
        /// <returns>A list of all drinks on the menu</returns>
        public static IEnumerable<IOrderItem> PlainDrinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new AretinoAppleJuice());
            drinks.Add(new CandlehearthCoffee());
            drinks.Add(new MarkarthMilk());
            drinks.Add(new WarriorWater());
            drinks.Add(new SailorSoda());
            return drinks;
        }

        /// <summary>
        /// Creates a list of every item on the menu, in all sizes and flavors
        /// </summary>
        /// <returns>A list of every item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.AddRange(Entrees());
            items.AddRange(Sides());
            items.AddRange(Drinks());
            return items;
        }
    }
}
