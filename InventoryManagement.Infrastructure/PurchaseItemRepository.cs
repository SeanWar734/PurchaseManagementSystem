using InventoryManagement.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure
{
    public class PurchaseItemRepository : IPurchaseItemRepository
    {
        private readonly InventoryContext _context;

        public PurchaseItemRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task Add(PurchaseItem purchaseItem)
        {
            await _context.PurchaseItems.AddAsync(purchaseItem);
        }

        public async Task DeletePurchaseItem(Guid purchaseItemId)
        {
            var purchaseItem = await _context.PurchaseItems.FindAsync(purchaseItemId);
            _context.Remove(purchaseItem);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdatePurchaseItem(PurchaseItem purchaseItem)
        {
            _context.Entry(purchaseItem).State = EntityState.Modified;
        }
    }
}
