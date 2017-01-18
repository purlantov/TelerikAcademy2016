using System;
using System.Collections.Generic;
using Cosmetics.Contracts;

namespace Cosmetics
{
    public interface IShoppingCart
    {
        ICollection<IProduct> ProductList { get; }

        void AddProduct(IProduct product);

        void RemoveProduct(IProduct product);

        bool ContainsProduct(IProduct product);

        decimal TotalPrice();
    }
}
