using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class PizzaMaker
    {
        static void Main(string[] args)
        {
            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor

            Pizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + basicPizza.Description);

            Console.WriteLine("Price: " + basicPizza.Cost);
        }
    }
}
