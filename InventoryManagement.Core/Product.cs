using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public class Product
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Brand { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public Guid ProductCategoryId { get; set; }
    }
}
