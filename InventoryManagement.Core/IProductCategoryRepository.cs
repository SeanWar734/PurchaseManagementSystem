using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public interface IProductCategoryRepository
    {
        Task Add(ProductCategory productCategory);
        Task DeleteProductCategory(Guid productCategoryId);
        void UpdateProductCategory(ProductCategory productCategory);
        Task Save();
    }
}
