using Blazored.Modal;
using InventoryManagement.Blazor.Data.Products;
using InventoryManagement.Blazor.Data.PurchaseItems;
using InventoryManagement.Blazor.Data.Purchases;
using InventoryManagement.Blazor.Data.Vendors;
using InventoryManagement.Shared.Products;
using InventoryManagement.Shared.PurchaseItems;
using InventoryManagement.Shared.Purchases;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class EditPurchaseItemBase : ComponentBase
    {
        [Inject] IPurchaseItemService PurchaseItemService { get; set; }
        [Inject] IProductService ProductService { get; set; }

        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public Guid PurchaseId { get; set; }
        [Parameter] public PurchaseItemListResponse? PurchaseItem { get; set; }

        public bool IsEdit;
        public List<ProductListResponse> Products;
        public CreatePurchaseItemRequest CreatePurchaseItem;
        public ProductListResponse Product;

        protected async override Task OnInitializedAsync()
        {

            IsEdit = PurchaseItem != null;

            Products = await ProductService.GetAllProductsAsync();

            if (PurchaseItem != null)
            {
                CreatePurchaseItem = new CreatePurchaseItemRequest
                {
                    Id = PurchaseItem.Id,
                    ProductId = PurchaseItem.ProductId,
                    Price = PurchaseItem.Price,
                    PurchaseId = PurchaseId,
                    Notes = PurchaseItem.Notes,
                    Quantity = PurchaseItem.Quantity,
                    UOM = PurchaseItem.UOM
                };
            }
            else
            {
                CreatePurchaseItem = new CreatePurchaseItemRequest
                {
                    PurchaseId = PurchaseId
                };
            }
        }
        public async Task DeletePurchaseItemAsync(Guid Id)
        {
            await PurchaseItemService.DeletePurchaseItemAsync(Id);
            await ModalInstance.CloseAsync();
        }

        public async Task AddPurchaseItemAsync(CreatePurchaseItemRequest CreatePurchaseItem)
        {
            await PurchaseItemService.AddNewPurchaseItemAsync(CreatePurchaseItem);
            await ModalInstance.CloseAsync();
        }
        public async Task UpdatePurchaseItemAsync(CreatePurchaseItemRequest CreatePurchaseItem)
        {
            var UpdatePurchaseItem = new UpdatePurchaseItemRequest
            {
                Id = CreatePurchaseItem.Id,
                ProductId = CreatePurchaseItem.ProductId,
                PurchaseId = CreatePurchaseItem.PurchaseId,
                Notes = CreatePurchaseItem.Notes,
                Price = CreatePurchaseItem.Price,
                Quantity = CreatePurchaseItem.Quantity,
                UOM = CreatePurchaseItem.UOM
            };
            await PurchaseItemService.UpdatePurchaseItemAsync(UpdatePurchaseItem);
            await ModalInstance.CloseAsync();
        }
        public async Task Cancel()
        {
            await ModalInstance.CancelAsync();
        }
    }
}
