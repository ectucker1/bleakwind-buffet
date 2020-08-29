using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: GardenOrcOmelette.cs
* Purpose: Class representing data for the Garden Orc Omelette menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Stores true if the omelette should contain broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Stores true if the omelette should contain mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Stores true if the omelette should contain tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Stores true if the omelette should contain cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Returns a list of special instructions for the omelette
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli)
                    instructions.Add("Hold broccoli");
                if (!Mushrooms)
                    instructions.Add("Hold mushrooms");
                if (!Tomato)
                    instructions.Add("Hold tomato");
                if (!Cheddar)
                    instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Garden Orc Omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
