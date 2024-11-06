using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Inventory.Types
{
    [QueryType]
    public class Query
    {
        [NodeResolver]
        public InventoryInfo GetInventoryInfo(
            int upc,
            [Service] InventoryInfoRepository repository) =>
            repository.GetInventoryInfo(upc);

        public double GetShippingEstimate(int price, int weight) =>
            price > 1000 ? 0 : weight * 0.5;
    }
}