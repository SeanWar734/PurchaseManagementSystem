using InventoryManagement.Shared.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Products
{
    public interface IProductService
    {
        Task<List<ProductListResponse>> GetAllProductsAsync();
        Task AddNewProductAsync(CreateProductRequest Product);
        Task DeleteProductAsync(Guid id);
        Task UpdateProductAsync(UpdateProductRequest Product);
        Task<ProductListResponse> GetOneProductAsync(Guid id);

    }
}
