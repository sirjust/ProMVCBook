using System.Collections.Generic;

namespace EssentialTools.Models
{
    public interface ILinqValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}