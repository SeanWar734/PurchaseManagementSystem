using Blazored.Modal.Services;
using InventoryManagement.Blazor.Data.Vendors;
using InventoryManagement.Shared.Vendors;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class VendorsBase : ComponentBase
    {
        [Inject] IVendorService VendorService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public List<VendorListResponse> Vendors;

        protected async override Task OnInitializedAsync()
        {
            Vendors = await VendorService.GetAllVendorsAsync();
        }
    }
}
