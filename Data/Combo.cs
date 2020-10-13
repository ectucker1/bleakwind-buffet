using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;

/*
* Author: Ethan Tucker
* Class name: Combo.cs
* Purpose: Represents a combo of an Entree, Side, and Drink
*/
namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler called whenever a property changes on this combo
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree = new BriarheartBurger();
        /// <summary>
        /// The Entree in this combo
        /// </summary>
        public Entree Entree {
            get => entree;
            set
            {
                entree.PropertyChanged -= OnItemPropertyChanged;
                entree = value;
                entree.PropertyChanged += OnItemPropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Entree)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Price)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Calories)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.SpecialInstructions)));
            }
        }

        private Side side = new DragonbornWaffleFries();
        /// <summary>
        /// The side in this combo
        /// </summary>
        public Side Side {
            get => side;
            set
            {
                side.PropertyChanged -= OnItemPropertyChanged;
                side = value;
                side.PropertyChanged += OnItemPropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Side)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Price)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Calories)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.SpecialInstructions)));
            }
        }

        private Drink drink = new SailorSoda();
        /// <summary>
        /// The drink in this combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink.PropertyChanged -= OnItemPropertyChanged;
                drink = value;
                drink.PropertyChanged += OnItemPropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Drink)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Price)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Calories)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.SpecialInstructions)));
            }
        }

        /// <summary>
        /// The total price of this combo, with a $1.00 discount
        /// </summary>
        public double Price => Entree.Price + Side.Price + Drink.Price - 1.00;

        /// <summary>
        /// The total calories of this combo
        /// </summary>
        public uint Calories => Entree.Calories + Side.Calories + Drink.Calories;

        /// <summary>
        /// A list of special instructions for this combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                instructions.Add(Entree.ToString());
                foreach (string instruction in Entree.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }
                instructions.Add(Side.ToString());
                foreach (string instruction in Side.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }
                instructions.Add(Drink.ToString());
                foreach (string instruction in Drink.SpecialInstructions)
                {
                    instructions.Add(" - " + instruction);
                }
                return instructions;
            }
        }

        /// <summary>
        /// The base name of the Combo
        /// </summary>
        public string BaseName => "Combo";

        /// <summary>
        /// Creates a new combo with the default Entree, Side, and Drink
        /// </summary>
        public Combo()
        {
            entree.PropertyChanged += OnItemPropertyChanged;
            side.PropertyChanged += OnItemPropertyChanged;
            drink.PropertyChanged += OnItemPropertyChanged;
        }

        /// <summary>
        /// Event listener called when a property of the Entree, Side, or Drink changes
        /// </summary>
        /// <param name="sender">The menu item which changed</param>
        /// <param name="e">Event arguments for the PropertyChanged event</param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IOrderItem.Price))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Price)));
            }
            else if (e.PropertyName == nameof(IOrderItem.Calories))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.Calories)));
            }
            else
            {
                // Combo's SpecialInstructions might still change in this case, e.g. if flavor is set on SailorSoda
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Combo.SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a string representation of a combo
        /// </summary>
        /// <returns>The string "Combo"</returns>
        public override string ToString()
        {
            return "Combo";
        }
    }
}
