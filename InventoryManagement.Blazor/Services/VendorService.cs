using InventoryManagement.Shared.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Vendors
{
    public class VendorService : IVendorService
    {
        private HttpClient HttpClient { get; set; }

        public VendorService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task AddNewVendorAsync(CreateVendorRequest Vendor)
        {
            var VendorJson = new StringContent(JsonSerializer.Serialize(Vendor), Encoding.UTF8, "application/json");
            await HttpClient.PostAsync($"vendors", VendorJson);
        }

        public async Task DeleteVendorAsync(Guid id)
        {
            await HttpClient.DeleteAsync($"vendors/{@id}");
        }

        public async Task<List<VendorListResponse>> GetAllVendorsAsync()
        {
            var result = await HttpClient.GetStreamAsync($"vendors/all");
            return await JsonSerializer.DeserializeAsync<List<VendorListResponse>>(result, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task<VendorListResponse> GetOneVendorAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateVendorAsync(UpdateVendorRequest Vendor)
        {
            throw new NotImplementedException();
        }
    }
}
