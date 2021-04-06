using InventoryManagement.Shared.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Products
{
    public class ProductService : IProductService
    {
        private HttpClient HttpClient { get; set; }

        public ProductService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewProductAsync(CreateProductRequest Product)
        {
            var ProductJson = new StringContent(JsonSerializer.Serialize(Product), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"products", ProductJson);
        }

        public async Task DeleteProductAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"products/{@id}");
        }

        public async Task<List<ProductListResponse>> GetAllProductsAsync()
        {
            var result = await HttpClient.GetStreamAsync($"products/all");
            return await JsonSerializer.DeserializeAsync<List<ProductListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateProductAsync(UpdateProductRequest Product)
        {
            var ProductJson = new StringContent(JsonSerializer.Serialize(Product), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"/products/{Product.Id}", ProductJson);
        }

        public async Task<ProductListResponse> GetOneProductAsync(Guid id)
        {
            return await HttpClient.GetFromJsonAsync<ProductListResponse>($"products/{id}");
        }
    }
}
