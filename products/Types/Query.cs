using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Products.Types
{
    [QueryType]
    public class Query
    {
        public IEnumerable<Product> GetTopProducts(
            int first,
            [Service] ProductRepository repository) =>
            repository.GetTopProducts(first);

        [NodeResolver]
        public Product GetProduct(
            int upc,
            [Service] ProductRepository repository) =>
            repository.GetProduct(upc);
    }
}