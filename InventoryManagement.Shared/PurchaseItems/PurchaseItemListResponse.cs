using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Shared.PurchaseItems
{
    public class PurchaseItemListResponse
    {
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
        public string PurchaseReferenceNumber { get; set; }
        public string ProductName { get; set; }
        public UnitOfMeasure UOM { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }

        public decimal GetTotal()
        {
            var total = Quantity * Price;
            return total;
        }
    }

    public enum UnitOfMeasure
    {
        Each = 1,
        Bag = 2,
        Box = 3,
        Lbs = 4
    }
}
