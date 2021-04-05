using InventoryManagement.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly InventoryContext _context;

        public ProductCategoryRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task Add(ProductCategory productCategory)
        {
            await _context.ProductCategories.AddAsync(productCategory);
        }

        public async Task DeleteProductCategory(Guid productCategoryId)
        {
            var productCategory = await _context.ProductCategories.FindAsync(productCategoryId);
            _context.Remove(productCategory);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            _context.Entry(productCategory).State = EntityState.Modified;
        }
    }
}
