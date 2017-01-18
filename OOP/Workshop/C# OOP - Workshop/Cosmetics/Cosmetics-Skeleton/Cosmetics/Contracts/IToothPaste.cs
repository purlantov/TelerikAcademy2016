namespace Cosmetics.Contracts
{
    using System.Collections.Generic;

    public interface IToothPaste : IProduct
    {
        IList<string> Ingredients { get; }
    }
}