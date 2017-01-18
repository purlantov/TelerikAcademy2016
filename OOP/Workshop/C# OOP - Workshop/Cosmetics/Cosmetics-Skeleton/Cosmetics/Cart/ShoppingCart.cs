using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Cart
{
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> productList;

        public ShoppingCart()
        {
            this.ProductList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get 
            {
                return this.productList;
            }
            set 
            {
                this.productList = value;
            }
        }

        public void AddProduct(IProduct product)
        {
            ProductList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            ProductList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return productList.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal result = 0;
            foreach (var item in ProductList)
            {
                result += item.Price; 
            }

            return result;
        }
    }
}
