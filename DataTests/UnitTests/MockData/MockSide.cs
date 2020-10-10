using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System.ComponentModel;

/*
 * Author: Ethan Tucker
 * Class: MockSide.cs
 * Purpose: Mock implementation of Side class used for testing
 */
namespace BleakwindBuffet.DataTests.UnitTests.MockData
{
    public class MockSide : Side
    {
        private double price;
        /// <summary>
        /// The price of this MockSide
        /// </summary>
        public override double Price => price;

        private uint calories;
        /// <summary>
        /// The number of calories in this MockSide
        /// </summary>
        public override uint Calories => calories;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A list of special instructions for this MockSide
        /// </summary>
        public override List<string> SpecialInstructions => specialInstructions;

        /// <summary>
        /// Creates a new MockSide with the given price and calories
        /// </summary>
        /// <param name="price">The price of this MockSide</param>
        /// <param name="calories">The number of calories in this MockSide</param>
        public MockSide(double price, uint calories)
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
        /// <returns>The string "Mock Side"</returns>
        public override string ToString()
        {
            return "Mock Side";
        }
    }
}
