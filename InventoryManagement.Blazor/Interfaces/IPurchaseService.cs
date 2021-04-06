using InventoryManagement.Shared.Purchases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.Purchases
{
    public interface IPurchaseService
    {
        Task<List<PurchaseListResponse>> GetAllPurchasesAsync();
        Task<PurchaseListResponse> GetOnePurchaseAsync(Guid id);
        Task AddNewPurchaseAsync(CreatePurchaseRequest Purchase);
        Task DeletePurchaseAsync(Guid id);
        Task UpdatePurchaseAsync(UpdatePurchaseRequest Purchase);
    }
}
