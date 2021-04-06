using InventoryManagement.Shared.Purchases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Purchases
{
    public class PurchaseService : IPurchaseService
    {
        private HttpClient HttpClient { get; set; }

        public PurchaseService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewPurchaseAsync(CreatePurchaseRequest Purchase)
        {
            var PurchaseJson = new StringContent(JsonSerializer.Serialize(Purchase), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"purchases", PurchaseJson);
        }

        public async Task DeletePurchaseAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"purchases/{@id}");
        }

        public async Task<List<PurchaseListResponse>> GetAllPurchasesAsync()
        {
            var result = await HttpClient.GetStreamAsync($"purchases/all");
            return await JsonSerializer.DeserializeAsync<List<PurchaseListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdatePurchaseAsync(UpdatePurchaseRequest Purchase)
        {
            var PurchaseJson = new StringContent(JsonSerializer.Serialize(Purchase), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"/purchases/{Purchase.Id}", PurchaseJson);
        }

        public async Task<PurchaseListResponse> GetOnePurchaseAsync(Guid id)
        {
            return await HttpClient.GetFromJsonAsync<PurchaseListResponse>($"purchases/{id}");
        }
    }
}
