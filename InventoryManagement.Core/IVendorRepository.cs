using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Core
{
    public interface IVendorRepository
    {
        Task Add(Vendor vendor);
        Task DeletePurchase(Guid vendorId);
        void UpdatePurchase(Vendor vendor);
        Task Save();
    }
}
