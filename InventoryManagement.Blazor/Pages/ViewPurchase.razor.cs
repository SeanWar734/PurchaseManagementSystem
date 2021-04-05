using Blazored.Modal;
using Blazored.Modal.Services;
using InventoryManagement.Blazor.Data.PurchaseItems;
using InventoryManagement.Blazor.Data.Purchases;
using InventoryManagement.Shared.PurchaseItems;
using InventoryManagement.Shared.Purchases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class ViewPurchaseBase : ComponentBase
    {
        [Inject] IPurchaseService PurchaseService { get; set; }
        [Inject] IPurchaseItemService PurchaseItemService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter] public Guid Id { get; set; }
        [CascadingParameter] public IModalService Modal { get; set; }

        public decimal Total;
        public PurchaseListResponse Purchase;
        public List<PurchaseItemListResponse> PurchaseItems;

        protected async override Task OnInitializedAsync()
        {
            Total = 0;
            Purchase = await PurchaseService.GetOnePurchaseAsync(Id);
            PurchaseItems = await PurchaseItemService.GetAllPurchaseItemsWithPurchaseIdAsync(Id);
            foreach (var item in PurchaseItems)
            {
                Total += item.GetTotal();
            }
        }

        public async Task Refresh()
        {
            Total = 0;
            PurchaseItems = await PurchaseItemService.GetAllPurchaseItemsWithPurchaseIdAsync(Id);
            foreach (var item in PurchaseItems)
            {
                Total += item.GetTotal();
            }
        }

        public async Task ShowEditPurchaseItemModal(Guid id, PurchaseItemListResponse PurchaseItem)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddEditPurchaseItem.PurchaseId), id);
            parameters.Add(nameof(AddEditPurchaseItem.PurchaseItem), PurchaseItem);

            var formModal = Modal.Show<AddEditPurchaseItem>("Edit Item", parameters);
            var result = await formModal.Result;

            if (result.Cancelled)
            {
            }
            else
            {
                await Refresh();
            }
        }
        public async Task ShowAddPurchaseItemModal(Guid id)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddEditPurchaseItem.PurchaseId), id);

            var formModal = Modal.Show<AddEditPurchaseItem>("Add New Item", parameters);
            var result = await formModal.Result;

            if (result.Cancelled)
            {
            }
            else
            {
                await Refresh();
            }
        }

        public void RedirectPurchases()
        {
            NavManager.NavigateTo("/purchases");
        }
    }
}
