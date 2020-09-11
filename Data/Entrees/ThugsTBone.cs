using System.Collections.Generic;

/*
* Author: Ethan Tucker
* Class name: ThugsTBone.cs
* Purpose: Class representing data for the Thugs T-Bone menu item
*/
namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Stores the price, calories, name, and special instructions for the Thugs T-Bone
    /// </summary>
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Gets the price of the T-Bone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Gets the calories of the T-Bone
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        /// Returns a list of special instructions for the T-Bone
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Returns the name of this entree
        /// </summary>
        /// <returns>The string "Thugs T-Bone"</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
