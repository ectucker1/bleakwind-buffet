using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

/*
* Author: Ethan Tucker
* Class name: Order.cs
* Purpose: Stores a list of items representing an order
*/
namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>
    {
        private double salesTaxRate = 0.12;
        /// <summary>
        /// The rate of sales tax for this Order
        /// </summary>
        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Total)));
            }
        }

        /// <summary>
        /// The subtotal of all items in this order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach (var item in this)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// The tax charged for the items in this order
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// The sum of the Subtotal and Tax for this order
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// The total number of calories in this order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint total = 0;
                foreach (var item in this)
                {
                    total += item.Calories;
                }
                return total;
            }
        }

        /// <summary>
        /// Private field used to assign order numbers sequentially
        /// </summary>
        private static uint nextOrderNum = 1;

        /// <summary>
        /// The numeric ID of this order
        /// </summary>
        public uint Number { get; private set; }

        /// <summary>
        /// Creates a new Order with the next order number
        /// </summary>
        public Order()
        {
            Number = nextOrderNum;
            nextOrderNum++;

            CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// Event handler called when the set of items in this collection changed
        /// </summary>
        /// <param name="sender">This collection</param>
        /// <param name="e">NotifyCollectionChanged event arguments</param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (IOrderItem item in e.NewItems)
                {
                    item.PropertyChanged += OnItemPropertyChanged;
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Total)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Calories)));
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (IOrderItem item in e.OldItems)
                {
                    item.PropertyChanged -= OnItemPropertyChanged;
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Total)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Calories)));
            }
        }

        /// <summary>
        /// Event handler called when an item in this collection changes
        /// </summary>
        /// <param name="sender">The item in the collection which changed</param>
        /// <param name="e">PropertyChanged event arguments</param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IOrderItem.Price))
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Subtotal)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Tax)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Total)));
            }
            else if (e.PropertyName == nameof(IOrderItem.Calories))
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Order.Calories)));
            }
        }
    }
}
