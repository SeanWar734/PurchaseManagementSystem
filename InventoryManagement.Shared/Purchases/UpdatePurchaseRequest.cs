using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Shared.Purchases
{
    public class UpdatePurchaseRequest
    {
        public Guid Id { get; set; }
        public Guid VendorId { get; set; }
        public DateTime Date { get; set; }
        public string ReferenceNumber { get; set; }
    }
}
