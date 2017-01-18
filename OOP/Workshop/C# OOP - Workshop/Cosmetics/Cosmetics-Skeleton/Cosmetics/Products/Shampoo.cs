using Cosmetics.Common;
using Cosmetics.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage) :
            base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; set; }

        public UsageType Usage { get; set; }

        public override string ToString()
        {
            return string.Format(
                $"- {Brand} - {Name}:\n  * Price: ${Price}\n  * For gender: {Gender}\n  * Quantity: {Milliliters} ml\n  * Usage: {Usage}\n");
        }
    }
}
