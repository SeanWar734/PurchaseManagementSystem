using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public class PurchaseItem
    {
        public Guid Id { get; set; }
        public Guid PurchaseId { get; set; }
        public Guid ProductId { get; set; }
        public UnitOfMeasure UOM { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        [StringLength(200)]
        public string Notes { get; set; }
    }

    public enum UnitOfMeasure
    {
        Each = 1,
        Bag = 2,
        Box = 3,
        Lbs = 4
    }
}
