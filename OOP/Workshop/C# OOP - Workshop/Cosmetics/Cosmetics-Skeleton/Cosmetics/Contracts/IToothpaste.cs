namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    public interface IToothPaste : IProduct
    {
        string Ingredients { get; }
    }
}