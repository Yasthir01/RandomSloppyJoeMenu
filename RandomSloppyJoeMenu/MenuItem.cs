using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSloppyJoeMenu
{
    class MenuItem
    {
        public static Random Randomizer = new Random();

        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

        public string[] Condiments = {"Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo",
        "Relish", "French Dressing"};

        public string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "A Roll" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];  // pick random protein from first item in list to last item in list
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];  // same as above but for condiments
            string randomBread = Breads[Randomizer.Next(Breads.Length)];  // same as above but for breads

            // use the above variables to create the description
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            // we want a price between 2.01 and 5.97
            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            Price = price.ToString("c");  // the argument of "c" is a format for the local currency

        }
    }
}
