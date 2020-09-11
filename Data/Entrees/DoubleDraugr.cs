using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: DoubleDraugr.cs
* Purpose: Class representing data for the Double Draugr menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Double Draugr
    /// </summary>
    public class DoubleDraugr : Entree
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Stores true if the bun should be left on this burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Stores true if ketchup should be left on this burger
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Stores true if mustard should be left on this burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Stores true if pickes should be left on this burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Stores true if cheese should be left on this burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Stores true if tomato should be left on this burger
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Stores true if lettuce should be left on this burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Stores true if mayo should be left on this burger
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Returns a list of special instructions for this burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun)
                    instructions.Add("Hold bun");
                if (!Ketchup)
                    instructions.Add("Hold ketchup");
                if (!Mustard)
                    instructions.Add("Hold mustard");
                if (!Pickle)
                    instructions.Add("Hold pickle");
                if (!Cheese)
                    instructions.Add("Hold cheese");
                if (!Tomato)
                    instructions.Add("Hold tomato");
                if (!Lettuce)
                    instructions.Add("Hold lettuce");
                if (!Mayo)
                    instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Double Draugr"</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
