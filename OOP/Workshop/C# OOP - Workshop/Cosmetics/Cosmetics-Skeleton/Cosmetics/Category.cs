using System;
using System.Collections.Generic;

using Cosmetics.Contracts;
using Cosmetics.Common;


namespace Cosmetics
{
    public class Category : ICategory
    {
        private string name;
        private const int min = 2;
        private const int max = 15;
        private ICollection<IProduct> productList;

        public Category(string name)
        {
            this.Name = name;
            this.ProdictList = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(
                    value,
                    max,
                    min,
                    string.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name + " name", min, max));

                this.name = value;
            }
        }

        public ICollection<IProduct> ProdictList
        {
            get
            {
                return this.productList;
            }
            private set
            {
                //if ((value == null) || (value.Count == 0))
                //{
                //    throw new NullReferenceException();
                //}

                this.productList = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            ProdictList.Add(cosmetics);
        }

        public string Print()
        {
            var products = string.Join("\n", productList);
            string product = null;
            if (productList.Count == 1)
            {
                product = "product";
            }else
            {
                product = "products";
            }
            if (productList.Count > 1)
            {
                return $"{Name} category - {ProdictList.Count} {product} in total\n{products}";
            }
            else
            {
                return $"{Name} category - {ProdictList.Count} {product} in total";
            }
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.ProdictList.Remove(cosmetics);
        }
    }
}
