using Blazored.Modal.Services;
using InventoryManagement.Blazor.Data.Products;
using InventoryManagement.Shared.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject] IProductService ProductService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [CascadingParameter] public IModalService Modal { get; set; }

        public List<ProductListResponse> Products;

        protected async override Task OnInitializedAsync()
        {
            Products = await ProductService.GetAllProductsAsync();
            Products = Products.OrderBy(p => p.ProductCategory).ThenBy(p => p.Brand).ToList();
        }

        public async Task Refresh()
        {
            Products = await ProductService.GetAllProductsAsync();
            Products = Products.OrderBy(p => p.ProductCategory).ThenBy(p => p.Brand).ToList();
        }

        public async Task ShowAddProductModal()
        {
            var formModal = Modal.Show<AddProduct>();
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
                await ProductService.DeleteProductAsync(Id);
                await Refresh();
            }
        }
    }
}
