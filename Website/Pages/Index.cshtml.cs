using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

/*
* Author: Ethan Tucker
* Class name: Index.cshtml.cs
* Purpose: Provide backing data for the Index page
*/
namespace BleakwindBuffet.Website.Pages
{
    /// <summary>
    /// Page model representing properties of the index page
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The minimum item price to be searched for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? MinPrice { get; set; }

        /// <summary>
        /// The maximum item price to be searched for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? MaxPrice { get; set; }

        /// <summary>
        /// The minimum number of calories to be searched for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? MinCalories { get; set; }

        /// <summary>
        /// The maximum number of calories to be searched for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? MaxCalories { get; set; }

        /// <summary>
        /// Terms to search for
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// True if entrees should be included in results
        /// </summary>
        public bool IncludeEntrees { get; set; } = true;

        /// <summary>
        /// True if sides should be included in results
        /// </summary>
        public bool IncludeSides { get; set; } = true;

        /// <summary>
        /// True if drinks should be included in results
        /// </summary>
        public bool IncludeDrinks { get; set; } = true;

        /// <summary>
        /// Called when a GET request is recieved
        /// </summary>
        public void OnGet()
        {
            // Don't change checkboxes from default of true if there's no form data
            if (Request.Query.Count > 0)
            {
                IncludeEntrees = Request.Query.ContainsKey(nameof(IncludeEntrees));
                IncludeSides = Request.Query.ContainsKey(nameof(IncludeSides));
                IncludeDrinks = Request.Query.ContainsKey(nameof(IncludeDrinks));
            }
        }
    }
}
