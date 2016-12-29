using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class TomatoSauce : ToppingDecorator, Pizza
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
        }

        // Returns the result of calling getDescription() for
        // PlainPizza, Mozzarella and then TomatoSauce

        public string Description()
        {

            return tempPizza.Description + ", tomato sauce";

        }

        public double Cost()
        {

            Console.WriteLine("Cost of Sauce: " + .35);

            return tempPizza.Cost + .35;

        }
    }
}
