using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Storage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();
        public static IEnumerable<Suggestion> Suggestions => suggestions;
        public static void addShop(Suggestion response)
        {
            suggestions.Add(response);
        }
    }
}
