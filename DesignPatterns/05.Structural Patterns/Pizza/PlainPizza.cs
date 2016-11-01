using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    // Implements the Pizza interface with only the required
    // methods from the interface

    // Every Pizza made will start as a PlainPizza

    class PlainPizza : Pizza
    {
        public double Cost
        {
            get
            {
                return 4.00;
            }
        }

        public string Description
        {
            get
            {
                return "Thin dough";
            }
        }
    }
}
