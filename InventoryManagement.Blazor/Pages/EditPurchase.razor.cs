using Blazored.Modal;
using Blazored.Modal.Services;
using InventoryManagement.Blazor.Data.Purchases;
using InventoryManagement.Blazor.Data.Vendors;
using InventoryManagement.Shared.Purchases;
using InventoryManagement.Shared.Vendors;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class EditPurchaseBase : ComponentBase
    {
        [Inject] IPurchaseService PurchaseService { get; set; }
        [Inject] IVendorService VendorService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid? Id { get; set; }
        [Parameter] public bool IsEdit { get; set; } = false;

        public CreatePurchaseRequest CreatePurchase;
        public PurchaseListResponse Purchase;

        public List<VendorListResponse> Vendors;

        protected async override Task OnInitializedAsync()
        {
            Vendors = await VendorService.GetAllVendorsAsync();

            if (IsEdit)
            {
                Purchase = await PurchaseService.GetOnePurchaseAsync((Guid)Id);

                CreatePurchase = new CreatePurchaseRequest()
                {
                    Id = Purchase.Id,
                    VendorId = Purchase.VendorId,
                    Date = Purchase.Date,
                    ReferenceNumber = Purchase.ReferenceNumber
                };
            } 
            else
            {
                CreatePurchase = new CreatePurchaseRequest
                {
                    Id = (Guid)Id,
                    Date = DateTime.Today
                };
            }
        }

        public async Task AddPurchaseAsync(CreatePurchaseRequest CreatePurchase)
        {
            await PurchaseService.AddNewPurchaseAsync(CreatePurchase);
            await ModalInstance.CloseAsync();
        }

        public async Task UpdatePurchaseAsync(CreatePurchaseRequest CreatePurchase)
        {
            var UpdatePurchase = new UpdatePurchaseRequest
            {
                Id = CreatePurchase.Id,
                VendorId = CreatePurchase.VendorId,
                Date = CreatePurchase.Date,
                ReferenceNumber = CreatePurchase.ReferenceNumber
            };
            await PurchaseService.UpdatePurchaseAsync(UpdatePurchase);
            await ModalInstance.CloseAsync();
        }


        public async Task Close()
        {
            await ModalInstance.CancelAsync();
        }
    }
}
