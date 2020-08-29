using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: SmokehouseSkeleton.cs
* Purpose: Class representing data for the Smokehouse Skeleton menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Stores true if the combo should come with a sausage link
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Stores true if the combo should come with eggs
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Stores true if the combo should come with hash browns
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Stores true if the combo should come with pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Returns a list of special instructions for the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink)
                    instructions.Add("Hold sausage");
                if (!Egg)
                    instructions.Add("Hold eggs");
                if (!HashBrowns)
                    instructions.Add("Hold hash browns");
                if (!Pancake)
                    instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Smokehouse Skeleton"</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
