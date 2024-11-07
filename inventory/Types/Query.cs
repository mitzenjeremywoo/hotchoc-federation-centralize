using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System.Collections.Generic;

namespace Inventory.Types
{
    [QueryType]
    public class Query
    {        
        public double GetShippingEstimate(int price, int weight) =>
            price > 1000 ? 0 : weight * 0.5;

        public IEnumerable<InventoryInfo> GetInventories([Service] InventoryInfoRepository repository) =>
            repository.GetInventories();


        [NodeResolver]
        public InventoryInfo GetInventory(
            int id,
            [Service] InventoryInfoRepository repository) =>
            repository.GetInventory(id);
    }
}