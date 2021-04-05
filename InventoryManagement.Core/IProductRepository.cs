using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public interface IProductRepository
    {
        Task Add(Product product);
        Task DeleteProduct(Guid productId);
        void UpdateProduct(Product product);
        Task Save();
    }
}
