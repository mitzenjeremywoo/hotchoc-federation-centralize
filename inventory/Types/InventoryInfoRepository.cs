using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Types
{
    public class InventoryInfoRepository
    {
        private readonly Dictionary<int, InventoryInfo> _infos;

        public InventoryInfoRepository()
        {
            _infos = new InventoryInfo[]
            {
                new InventoryInfo(1, true),
                new InventoryInfo(2, false),
                new InventoryInfo(3, true)
            }.ToDictionary(t => t.Id);
        }

        public InventoryInfo GetInventory(int id) => _infos[id];

        public IEnumerable<InventoryInfo> GetInventories() => _infos.Values;
    }
}