using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Ethan Tucker
 * Class name: RecieptGenerator.cs
 * Purpose: Provide methods to generate and complete reciepts of orders
 */
namespace PointOfSale.Controls.Payment
{
    public class RecieptGenerator
    {
        /// <summary>
        /// Generates and prints a reciept for the given order with the given payment method
        /// </summary>
        /// <param name="order">The order to print a reciept for</param>
        /// <param name="paidCash">True if the customer paid in cash</param>
        /// <param name="changeOwed">The amount of change owed to the customer</param>
        public static void PrintReciept(Order order, bool paidCash = false, double changeOwed = 0.0)
        {
            List<string> reciept = GenerateReciept(order, paidCash, changeOwed);
            foreach (string line in reciept)
            {
                RecieptPrinter.PrintLine(line);
            }
            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Generates a reciept for the given order with the given payment method
        /// </summary>
        /// <param name="order">The order to print a reciept for</param>
        /// <param name="paidCash">True if the customer paid in cash</param>
        /// <param name="changeOwed">The amount of change owed to the customer</param>
        /// <returns>A list of lines in the reciept</returns>
        public static List<string> GenerateReciept(Order order, bool paidCash = false, double changeOwed = 0.0)
        {
            List<string> reciept = new List<string>();
            AddWrappedLine(reciept, $"Order #{order.Number:D4}");
            AddWrappedLine(reciept, $"Submitted at {DateTime.Now}");
            foreach (IOrderItem item in order)
            {
                AddWrappedLine(reciept, $"{item} - {item.Price:C2}");
                foreach (string instruction in item.SpecialInstructions)
                {
                    AddWrappedLine(reciept, instruction);
                }
            }
            AddWrappedLine(reciept, $"Subtotal: {order.Subtotal:C2}");
            AddWrappedLine(reciept, $"Tax: {order.Tax:C2}");
            AddWrappedLine(reciept, $"Total: {order.Total:C2}");
            if (paidCash)
            {
                AddWrappedLine(reciept, "Paid with cash");
                AddWrappedLine(reciept, $"Change owed: {changeOwed:C2}");
            }
            else
            {
                AddWrappedLine(reciept, "Paid with card");
            }
            return reciept;
        }

        /// <summary>
        /// Calls WrapLine with the given line and adds it to the given reciept
        /// </summary>
        /// <param name="reciept">The reciept to add a line to</param>
        /// <param name="line">The line of text to add to the reciept</param>
        public static void AddWrappedLine(List<string> reciept, string line)
        {
            string[] wrapped = WrapLine(line);
            foreach (string shortened in wrapped)
            {
                reciept.Add(shortened);
            }
        }

        /// <summary>
        /// Returns a list of strings by splitting the text onto multiple lines
        /// </summary>
        /// <param name="line">A line to print in a reciepr</param>
        /// <returns>An array of lines with shorter length</returns>
        public static string[] WrapLine(string line)
        {
            string[] results = new string[(int) Math.Ceiling(line.Length / 40.0)];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = line.Substring(0, Math.Min(40, line.Length));
                line = line.Substring(results[i].Length);
            }
            return results;
        }
    }
}
