using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    // Has a "Has a" relationship with Pizza. This is an
    // Aggregation Relationship

    public class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;

        // Assigns the type instance to this attribute
        // of a Pizza

        // All decorators can dynamically customize the Pizza
        // instance PlainPizza because of this

        public ToppingDecorator(Pizza newPizza)
        {
            tempPizza = newPizza;
        }

        public double Cost
        {
            get
            {
                return tempPizza.Cost;
            }
        }

        public string Description
        {
            get
            {
                return tempPizza.Description;
            }
        }
    }
}
