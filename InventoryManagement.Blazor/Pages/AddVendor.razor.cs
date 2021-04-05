using Blazored.Modal;
using InventoryManagement.Blazor.Data.Vendors;
using InventoryManagement.Shared.Vendors;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class AddVendorBase : ComponentBase
    {
        [Inject] IVendorService VendorService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        public CreateVendorRequest Vendor;

        protected async override Task OnInitializedAsync()
        {
            Vendor = new CreateVendorRequest();
        }

        public async Task AddVendor(CreateVendorRequest Vendor)
        {
            await VendorService.AddNewVendorAsync(Vendor);
            await ModalInstance.CloseAsync();
        }
    }
}
