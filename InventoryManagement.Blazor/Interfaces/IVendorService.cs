using InventoryManagement.Shared.Vendors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Vendors
{
    public interface IVendorService
    {
        Task<List<VendorListResponse>> GetAllVendorsAsync();
        Task<VendorListResponse> GetOneVendorAsync(Guid id);
        Task AddNewVendorAsync(CreateVendorRequest Vendor);
        Task DeleteVendorAsync(Guid id);
        Task UpdateVendorAsync(UpdateVendorRequest Vendor);
    }
}
