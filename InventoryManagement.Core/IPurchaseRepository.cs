using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public interface IPurchaseRepository
    {
        Task Add(Purchase purchase);
        Task DeletePurchase(Guid purchaseId);
        void UpdatePurchase(Purchase purchase);
        Task Save();
    }
}
