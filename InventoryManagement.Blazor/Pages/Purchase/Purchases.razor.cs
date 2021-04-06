using Blazored.Modal;
using Blazored.Modal.Services;
using InventoryManagement.Blazor.Data.PurchaseItems;
using InventoryManagement.Blazor.Data.Purchases;
using InventoryManagement.Blazor.Data.Vendors;
using InventoryManagement.Blazor.Pages.Purchase;
using InventoryManagement.Blazor.Shared;
using InventoryManagement.Shared.PurchaseItems;
using InventoryManagement.Shared.Purchases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class PurchasesBase : ComponentBase
    {
        [Inject] IPurchaseService PurchaseService { get; set; }
        [Inject] IPurchaseItemService PurchaseItemService { get; set; }

        [Inject] NavigationManager NavManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public List<PurchaseListResponse> Purchases;
        public List<PurchaseItemListResponse> PurchaseItems;
        public bool IsLoading { get; set; } = false;

        public bool DateToggled = true;
        public bool ReferenceNumberToggled = false;
        public bool VendorNameToggled = false;
        public bool TotalToggled = false;

        protected async override Task OnInitializedAsync()
        {
            await Refresh();
            SortByDateDescending();
        }

        public async Task Refresh()
        {
            IsLoading = true;
            StateHasChanged();

            Purchases = await PurchaseService.GetAllPurchasesAsync();
            PurchaseItems = await PurchaseItemService.GetAllPurchaseItemsAsync();

            foreach (var purchase in Purchases)
            {
                foreach (var purchaseItem in PurchaseItems)
                {
                    if (purchaseItem.PurchaseId == purchase.Id)
                    {
                        purchase.Total += purchaseItem.GetTotal();
                    }
                }
            }

            IsLoading = false;
            StateHasChanged();
        }

        public void RedirectViewPurchase(Guid id)
        {
            NavManager.NavigateTo("/viewpurchase/" + id);
        }

        public async Task ShowEditPurchaseModal(Guid id)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddEditPurchase.Id), id); 
            parameters.Add(nameof(AddEditPurchase.IsEdit), true);

            var formModal = Modal.Show<AddEditPurchase>("Edit Purchase", parameters);
            var result = await formModal.Result;

            if (result.Cancelled) { }
            else 
            {
                NavManager.NavigateTo("/viewpurchase/" + id);
            }
        }

        public async Task ShowAddPurchaseModal()
        {
            Guid id = Guid.NewGuid();
            var parameters = new ModalParameters();
            parameters.Add(nameof(AddEditPurchase.Id), id);

            var formModal = Modal.Show<AddEditPurchase>("Add New Purchase", parameters);
            var result = await formModal.Result;

            if (result.Cancelled) { }
            else
            {
                Console.WriteLine("Breakpoint");
                NavManager.NavigateTo("/viewpurchase/" + id);
            }
        }
        public async Task ShowDeletePurchaseModal(Guid Id)
        {
            var formModal = Modal.Show<Confirmation>("Are you sure you want to Delete?");
            var result = await formModal.Result;

            if (result.Cancelled) { }
            else
            {
                await PurchaseService.DeletePurchaseAsync(Id);
                await Refresh();
            }
        }

        public void SwitchSortDate()
        {
            if (!DateToggled)
            {
                SortByDateAscending();
                DateToggled = true;
            } 
            else
            {
                SortByDateDescending();
                DateToggled = false;
            }
        }
        public void SortByDateAscending()
        {
            Purchases = Purchases.OrderBy(p => p.Date).ToList();
        }
        public void SortByDateDescending()
        {
            Purchases = Purchases.OrderByDescending(p => p.Date).ToList();
        }
        public void SwitchSortReferenceNumber()
        {
            if (!ReferenceNumberToggled)
            {
                SortByReferenceNumberAscending();
                ReferenceNumberToggled = true;
            }
            else
            {
                SortByReferenceNumberDescending();
                ReferenceNumberToggled = false;
            }
        }
        public void SortByReferenceNumberAscending()
        {
            Purchases = Purchases.OrderBy(p => p.ReferenceNumber).ToList();
        }
        public void SortByReferenceNumberDescending()
        {
            Purchases = Purchases.OrderByDescending(p => p.ReferenceNumber).ToList();
        }
        public void SwitchSortVendorName()
        {
            if (!VendorNameToggled)
            {
                SortByVendorNameAscending();
                VendorNameToggled = true;
            }
            else
            {
                SortByVendorNameDescending();
                VendorNameToggled = false;
            }
        }
        public void SortByVendorNameAscending()
        {
            Purchases = Purchases.OrderBy(p => p.VendorName).ToList();
        }
        public void SortByVendorNameDescending()
        {
            Purchases = Purchases.OrderByDescending(p => p.VendorName).ToList();
        }
        public void SwitchSortTotal()
        {
            if (!TotalToggled)
            {
                SortByTotalAscending();
                TotalToggled = true;
            }
            else
            {
                SortByTotalDescending();
                TotalToggled = false;
            }
        }
        public void SortByTotalAscending()
        {
            Purchases = Purchases.OrderBy(p => p.Total).ToList();
        }
        public void SortByTotalDescending()
        {
            Purchases = Purchases.OrderByDescending(p => p.Total).ToList();
        }
    }
}
