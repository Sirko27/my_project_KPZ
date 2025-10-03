using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Burger
    {
        public string Cheese = "";
        public string Meat = "";
        public string Salad = "";
        public string Tomato = "";
        public string Sauce = "";
        public string Bread = "";

        public string getInfo()
        {
            return "Manual Burger: Cheese: " + Cheese + ", Meat: " + Meat + ", Salad: " + Salad + ", Tomato: " + Tomato + ", Sauce: " + Sauce + ", Bread:" + Bread;
        }
    }
}
