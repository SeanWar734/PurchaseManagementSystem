#pragma checksum "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "080c95abd30cefe949d7a504af3c759b43f17f9f"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryManagement.Blazor.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using InventoryManagement.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using InventoryManagement.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : ProductsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
 if (Products != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "py-2 text-right");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "border-2 border-black w-40 hover:bg-gray-300");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                                                                 () => ShowAddProductModal()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table-auto border-t-2 border-b-2 border-black table table-striped");
            __builder.AddMarkupContent(9, @"<tr><th class=""w-40 bg-gray-300 border-l-2 border-r-2 border-black""><div>Product</div></th>
            <th class=""w-40 bg-gray-300 border-l-2 border-r-2 border-black""><div>Brand</div></th>
            <th class=""w-40 bg-gray-300 border-l-2 border-r-2 border-black""><div>Category</div></th>
            <th class=""w-40 bg-gray-300 border-l-2 border-r-2 border-black""><div>Description</div></th></tr>");
#nullable restore
#line 16 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
         foreach (var product in Products)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(13, 
#nullable restore
#line 19 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(17, 
#nullable restore
#line 20 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                                                product.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(21, 
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                                                product.ProductCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "border-l-2 border-r-2 border-black");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "float-left");
            __builder.AddContent(27, 
#nullable restore
#line 23 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                             product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "float-right");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "w-4");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
                                                                           (() => ShowDeleteVendorModal(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "x");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<div class=\"fixed top-0 right-0 h-screen w-screen z-50 flex justify-center items-center\"><div class=\"animate-spin rounded-full h-32 w-32 border-t-2 border-b-2 border-gray-900\"></div></div>");
#nullable restore
#line 35 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Product\Products.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
