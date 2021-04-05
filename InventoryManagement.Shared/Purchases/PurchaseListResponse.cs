using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Shared.Purchases
{
    public class PurchaseListResponse
    {
        public Guid Id { get; set; }
        public Guid VendorId { get; set; }
        public string VendorName { get; set; }
        public DateTime Date { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Total { get; set; } = 0;
    }
}
