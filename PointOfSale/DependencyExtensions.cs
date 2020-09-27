/*
 * Author: Nathan Bean
 * Edited by: Ethan Tucker
 * Class name: DependencyExtensions.cs
 * Purpose: Provide extension methods for DependencyObjects
 */
using System.Windows;
using System.Windows.Media;

namespace BleakwindBuffet.PointOfSale
{
    public static class DependencyExtensions
    {
        /// <summary>
        /// Finds the control of the type passed to the function
        /// </summary>
        /// <typeparam name="T">The type of control to search for</typeparam>
        /// <param name="element">The element to search the parents of</param>
        /// <returns>The first ancestor control of the given type</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent == null)
                return null;

            if (parent is T ancestor)
                return ancestor;

            return parent.FindAncestor<T>();
        }
    }
}
