using Blazored.Modal;
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

        public async Task Refresh()
        {
            Vendors = await VendorService.GetAllVendorsAsync();
        }

        public async Task ShowAddVendorModal()
        {
            var formModal = Modal.Show<AddVendor>();
            var result = await formModal.Result;

            if (result.Cancelled) { }
            else
            {
                await Refresh();
            }
        }

        public async Task ShowDeleteVendorModal(Guid Id)
        {
            var formModal = Modal.Show<Confirmation>("Are you sure you want to Delete?");
            var result = await formModal.Result;

            if (result.Cancelled) { }
            else
            {
                await VendorService.DeleteVendorAsync(Id);
                await Refresh();
            }
        }
    }
}
