using InventoryManagement.Blazor.Data.Products;
using InventoryManagement.Shared.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] IProductService ProductService { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        public List<ProductListResponse> Products;

        protected async override Task OnInitializedAsync()
        {
            Products = await ProductService.GetAllProductsAsync();
        }
    }
}
