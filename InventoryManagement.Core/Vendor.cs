using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryManagement.Core
{
    public class Vendor
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}
