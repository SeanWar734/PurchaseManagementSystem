using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Shared.PurchaseItems
{
    public class CreatePurchaseItemRequest
    {
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
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
}
