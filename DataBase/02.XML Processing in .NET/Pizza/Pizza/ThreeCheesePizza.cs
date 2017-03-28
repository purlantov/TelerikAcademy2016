using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    // By going this route I'll have to create a new subclass
    // for an infinite number of pizza.
    // I'd also have to change prices in many classes 
    // when just 1 Pizza topping cost changes

    // Inheritance is static while composition is dynamic
    // Through composition I'll be able to add new functionality
    // by writing new code rather than by changing current code

    public class ThreeCheesePizza : Pizza
    {


    private string description = "Mozzarella, Fontina, Parmesan Cheese Pizza";
    private double cost = 10.50;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }

        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                this.cost = value;
            }
        }
    }
}
