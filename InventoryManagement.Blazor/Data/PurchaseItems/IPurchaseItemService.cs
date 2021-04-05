using InventoryManagement.Shared.PurchaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Data.PurchaseItems
{
    public interface IPurchaseItemService
    {
        Task<List<PurchaseItemListResponse>> GetAllPurchaseItemsAsync();
        Task<PurchaseItemListResponse> GetOnePurchaseItemAsync(Guid id);
        Task<List<PurchaseItemListResponse>> GetAllPurchaseItemsWithPurchaseIdAsync(Guid id);
        Task AddNewPurchaseItemAsync(CreatePurchaseItemRequest PurchaseItem);
        Task DeletePurchaseItemAsync(Guid id);
        Task UpdatePurchaseItemAsync(UpdatePurchaseItemRequest PurchaseItem);

    }
}
