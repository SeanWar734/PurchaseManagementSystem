using InventoryManagement.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly InventoryContext _context;

        public PurchaseRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task Add(Purchase purchase)
        {
            await _context.AddAsync(purchase);
        }

        public async Task DeletePurchase(Guid purchaseId)
        {
            var purchase = await _context.Purchases.FindAsync(purchaseId);
            _context.Remove(purchase);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdatePurchase(Purchase purchase)
        {
            _context.Entry(purchase).State = EntityState.Modified;
            Console.WriteLine("Breakpoint");
        }
    }
}
