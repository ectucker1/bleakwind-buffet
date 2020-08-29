using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: BriarheartBurger.cs
* Purpose: Class representing data for the Briarheart Burger menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 743;

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
        /// Returns a list of special instructions for this burger
        /// </summary>
        public List<string> SpecialInstructions {
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
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
