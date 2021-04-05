using InventoryManagement.Shared.PurchaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.PurchaseItems
{
    public class PurchaseItemService : IPurchaseItemService
    {
        private HttpClient HttpClient { get; set; }

        public PurchaseItemService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewPurchaseItemAsync(CreatePurchaseItemRequest PurchaseItem)
        {
            var PurchaseItemJson = new StringContent(JsonSerializer.Serialize(PurchaseItem), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"purchaseitems", PurchaseItemJson);
        }
        public async Task UpdatePurchaseItemAsync(UpdatePurchaseItemRequest PurchaseItem)
        {
            var PurchaseItemJson = new StringContent(JsonSerializer.Serialize(PurchaseItem), Encoding.UTF8, "application/json");
            await HttpClient.PutAsync($"purchaseitems/{@PurchaseItem.Id}", PurchaseItemJson);
        }
        public async Task DeletePurchaseItemAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"purchaseitems/" + id);
        }

        public async Task<List<PurchaseItemListResponse>> GetAllPurchaseItemsAsync()
        {
            var result = await HttpClient.GetStreamAsync($"purchaseitems/all");
            return await JsonSerializer.DeserializeAsync<List<PurchaseItemListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<List<PurchaseItemListResponse>> GetAllPurchaseItemsWithPurchaseIdAsync(Guid id)
        {
            var result = await HttpClient.GetStreamAsync($"purchaseitems/" + id);
            return await JsonSerializer.DeserializeAsync<List<PurchaseItemListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PurchaseItemListResponse> GetOnePurchaseItemAsync(Guid id)
        {
            return await HttpClient.GetFromJsonAsync<PurchaseItemListResponse>($"purchaseitems/one/{id}");
        }
    }
}
