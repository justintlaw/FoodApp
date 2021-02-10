using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Shop
    {
        public Shop(int rank, string name, string address, string favDish = "It's all tasty!", string phoneNumber = null, string websiteLink = "Coming soon.")
        {
            this.rank = rank;
            this.name = name;
            this.favDish = favDish;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.websiteLink = websiteLink;
        }

        [Required]
        public int rank { get; }

        [Required]
        public string name { get; set; }

        [Required]
        public string address { get; set; }

        public string favDish { get; set; } = "It's all tasty!";

        [Phone]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")]
        public string? phoneNumber { get; set; }
        public string? websiteLink { get; set; } = "Coming soon.";

        // Return top 5 shops as a list
        public static Shop[] GetTopShops()
        {
            return new Shop[] {
                new Shop(rank: 1, name: "McDonald's", address: "1234 Main Street", websiteLink: "https://www.mcdonalds.com/us/en-us.html"),
                new Shop(2, "Wendy's", "12 51st Lane", "Baconator", websiteLink: "https://www.wendys.com/"),
                new Shop(3, "Burger King", "Burger King St.", "Whopper"),
                new Shop(4, "Taco Bell", "1234 Taco Stree N", "Taco", websiteLink: "https://www.tacobell.com/"),
                new Shop(5, "Chick-fil-a", "Heaven", "Chicken Sandwich", websiteLink: "https://www.chick-fil-a.com/")
            };
        }
    }
}
