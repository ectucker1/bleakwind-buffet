using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System;
using System.Linq;

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


        /// <summary>
        /// Filters the given collection of order items to those with the types allowed
        /// </summary>
        /// <param name="items">The collection of order items to filter</param>
        /// <param name="includeEntrees">True if Entrees should be included</param>
        /// <param name="includeSides">True if Sides should be included</param>
        /// <param name="includeDrinks">True if Drinks should be included</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, bool includeEntrees, bool includeSides, bool includeDrinks)
        {
            return items.Where(item =>
                (includeEntrees && item is Entree)
                || (includeSides && item is Side)
                || (includeDrinks && item is Drink));
        }

        /// <summary>
        /// Filters the given collection of order items to those with a price in the specified range
        /// </summary>
        /// <param name="movies">The collection of order items to filter</param>
        /// <param name="min">The minimum price</param>
        /// <param name="max">The maximum price</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            // only a maximum specified
            if (min == null)
                return items.Where(item => item.Price <= max);

            // only a minimum specified
            if (max == null)
                return items.Where(item => item.Price >= min);

            // Both minimum and maximum specified
            return items.Where(item => item.Price >= min && item.Price <= max);
        }

        /// <summary>
        /// Filters the given collection of order items to those with a calorie count in the specified range
        /// </summary>
        /// <param name="movies">The collection of order items to filter</param>
        /// <param name="min">The minimum number of calories</param>
        /// <param name="max">The maximum number of calories</param>
        /// <returns>The filtered order item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;

            // only a maximum specified
            if (min == null)
                return items.Where(item => item.Calories <= max);

            // only a minimum specified
            if (max == null)
                return items.Where(item => item.Calories >= min);

            // Both minimum and maximum specified
            return items.Where(item => item.Calories >= min && item.Calories <= max);
        }

        /// <summary>
        /// Searches menu items for one containing the given terms
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // null check
            if (terms == null) return items;

            foreach (IOrderItem item in items)
            {
                // Add the item if the name is a match
                // IndexOf is used instead of Contains to allow for use of InvariantCultureIgnoreCase
                if (item.BaseName.IndexOf(terms, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Remove all items with the same type from the given list
        /// </summary>
        /// <param name="items">The list of order items to filter</param>
        /// <returns>A new list without duplicate types</returns>
        public static IEnumerable<IOrderItem> FilterDuplicates(IEnumerable<IOrderItem> items)
        {
            var results = new List<IOrderItem>();

            // Return only the items which are the first of their type in the collection
            return items.Where(item => items.Where(other => other.GetType() == item.GetType()).First() == item);
        }
    }
}
