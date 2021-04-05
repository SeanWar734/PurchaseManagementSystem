using Blazored.Modal;
using InventoryManagement.Blazor.Data.Products;
using InventoryManagement.Shared.Products;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Blazor.Pages
{
    public class AddProductBase : ComponentBase
    {
        [Inject] IProductService ProductService { get; set; }
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        public CreateProductRequest Product;

        protected async override Task OnInitializedAsync()
        {
            Product = new CreateProductRequest();
        }

        public async Task AddProduct(CreateProductRequest Product)
        {
            await ProductService.AddNewProductAsync(Product);
            await ModalInstance.CloseAsync();
        }
    }
}
