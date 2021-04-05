using InventoryManagement.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure
{
    public class VendorRepository : IVendorRepository
    {
        private readonly InventoryContext _context;

        public VendorRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task Add(Vendor vendor)
        {
            await _context.Vendors.AddAsync(vendor);
        }

        public async Task DeletePurchase(Guid vendorId)
        {
            var vendor = await _context.Vendors.FindAsync(vendorId);
            _context.Remove(vendor);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdatePurchase(Vendor vendor)
        {
            _context.Entry(vendor).State = EntityState.Modified;
        }
    }
}
