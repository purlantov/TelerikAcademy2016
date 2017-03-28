using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Mozzarella : ToppingDecorator, Pizza
    {
        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");

            Console.WriteLine("Adding Moz");
        }

        // Returns the result of calling getDescription() for
        // PlainPizza and adds " mozzarella" to it

        public string Description()
        {

            return tempPizza.Description + ", mozzarella";

        }

        public double Cost()
        {

            Console.WriteLine("Cost of Moz: " + .50);

            return tempPizza.Cost + .50;

        }
    }
}
