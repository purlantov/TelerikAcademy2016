using System;
using System.Collections.Generic;

using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Engine
{
    public class ToothPaste : Product, IToothPaste
    {
        private IList<string> ingredients;

        public ToothPaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients) :
            base(name, brand, price, gender)
        {
            this.ingredients = ingredients;
        }


        public IList<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }
            set
            {
                this.ingredients = value;
            }
        }

        public override string ToString()
        {
            var ingredientss = string.Join(", ", Ingredients);

            return string.Format(
                $"- {Brand} - {Name}:\n  * Price: ${Price}\n  * For gender: {Gender}\n  * Ingredients: {ingredientss}");
        }
    }
}