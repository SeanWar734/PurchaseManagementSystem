using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public interface IPurchaseItemRepository
    {
        Task Add(PurchaseItem purchaseItem);
        Task DeletePurchaseItem(Guid purchaseItemId);
        void UpdatePurchaseItem(PurchaseItem purchaseItem);
        Task Save();
    }
}
