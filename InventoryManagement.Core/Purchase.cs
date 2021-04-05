using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public Guid VendorId { get; set; }
        public DateTime Date { get; set; }
        [StringLength(100)]
        public string ReferenceNumber { get; set; }
    }
}
