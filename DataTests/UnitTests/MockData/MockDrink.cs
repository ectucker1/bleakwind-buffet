using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;
using System.ComponentModel;

/*
 * Author: Ethan Tucker
 * Class: MockDrink.cs
 * Purpose: Mock implementation of Drink class used for testing
 */
namespace BleakwindBuffet.DataTests.UnitTests.MockData
{
    public class MockDrink : Drink
    {
        private double price;
        /// <summary>
        /// The price of this MockDrink
        /// </summary>
        public override double Price => price;

        private uint calories;
        /// <summary>
        /// The number of calories in this MockDrink
        /// </summary>
        public override uint Calories => calories;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A list of special instructions for this MockDrink
        /// </summary>
        public override List<string> SpecialInstructions => specialInstructions;

        /// <summary>
        /// The base name of this MockDrink
        /// </summary>
        public override string BaseName => "Mock Drink";

        /// <summary>
        /// The description of the MockDrink
        /// </summary>
        public override string Description => "Refreshing streams of 0's and 1's used for unit testing.";

        /// <summary>
        /// Creates a new MockDrink with the given price and calories
        /// </summary>
        /// <param name="price">The price of this MockDrink</param>
        /// <param name="calories">The number of calories in this MockDrink</param>
        public MockDrink(double price, uint calories)
        {
            this.price = price;
            this.calories = calories;
        }

        /// <summary>
        /// Setter for the price field.
        /// </summary>
        /// <note>This is only necessary as Price has no public setter</note>
        /// <param name="price">The price to set for this menu item</param>
        public void SetPrice(double price)
        {
            this.price = price;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Price)));
        }

        /// <summary>
        /// Setter for the calories field.
        /// </summary>
        /// <note>This is only necessary as Calories has no public setter</note>
        /// <param name="price">The calories to set for this menu item</param>
        public void SetCalories(double price)
        {
            this.price = price;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Calories)));
        }

        /// <summary>
        /// Adds an instruction to the SpecialInstructions property of this menu item
        /// </summary>
        /// <param name="instruction"></param>
        public void AddInstruction(string instruction)
        {
            SpecialInstructions.Add(instruction);
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
        }

        /// <summary>
        /// Returns a string representation of this mock menu item
        /// </summary>
        /// <returns>The string "Mock Drink"</returns>
        public override string ToString()
        {
            return "Mock Drink";
        }
    }
}
