using System;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics
{
    public class Product : IProduct
    {
        private decimal price;
        private string name;
        private string brand;
        private GenderType gender;
        private const int productNameMin = 3;
        private const int productNameMax = 10;
        private const int brandNameMin = 2;
        private const int brandNameMax = 10;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value, brandNameMax, brandNameMin, $"Product brand must be between {brandNameMin} and {brandNameMax} symbols long!");
                this.brand = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
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
                    value, productNameMax, productNameMin, $"Product name must be between {productNameMin} and {productNameMax} symbols long!");
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public string Print()
        {
            return ToString();
        }
    }
}
