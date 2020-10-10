using System.Collections.Generic;
using System.ComponentModel;

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
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the breakfast combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Backing field for the SausageLink property
        /// </summary>
        private bool sausageLink = true;

        /// <summary>
        /// Stores true if the combo should come with a sausage link
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SausageLink)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Egg property
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// Stores true if the combo should come with eggs
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Egg)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the HashBrowns property
        /// </summary>
        private bool hashBrowns = true;

        /// <summary>
        /// Stores true if the combo should come with hash browns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(HashBrowns)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Backing field for the Pancake property
        /// </summary>
        private bool pancake = true;

        /// <summary>
        /// Stores true if the combo should come with pancakes
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Pancake)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SpecialInstructions)));
            }
        }

        /// <summary>
        /// Returns a list of special instructions for the combo
        /// </summary>
        public override List<string> SpecialInstructions
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
