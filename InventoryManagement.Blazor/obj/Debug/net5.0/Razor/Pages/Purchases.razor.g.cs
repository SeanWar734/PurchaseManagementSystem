#pragma checksum "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44aa836d7c63b31ee53263f83c501c01375e578b"
// <auto-generated/>
#pragma warning disable 1591
namespace InventoryManagement.Blazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchases")]
    public partial class Purchases : PurchasesBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
 if (Purchases != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "py-2 text-right");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "border-2 border-black w-40");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                               () => ShowAddPurchaseModal()

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
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "th");
            __builder.AddAttribute(11, "class", "w-40 bg-gray-300 border-l-2 border-r-2 border-black");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                              SwitchSortDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<div class=\"text-left font-bold\">Date</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "class", "w-40 bg-gray-300 border-l-2 border-r-2 border-black");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                              SwitchSortReferenceNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "<div class=\"text-left font-bold\">Reference Number</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "th");
            __builder.AddAttribute(23, "class", "w-40 bg-gray-300 border-l-2 border-r-2 border-black");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                              SwitchSortVendorName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<div class=\"text-left font-bold\">Vendor Name</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "th");
            __builder.AddAttribute(29, "class", "w-40 bg-gray-300 border-l-2 border-r-2 border-black");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                              SwitchSortTotal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<div class=\"text-left font-bold\">Total</div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<th class=\"w-20 bg-gray-300 border-l-2 border-r-2 border-black\"><div class=\"text-left\">Edit</div></th>\r\n            ");
            __builder.AddMarkupContent(35, "<th class=\"w-20 bg-gray-300 border-l-2 border-r-2 border-black\"><div class=\"text-left\">Delete</div></th>\r\n            ");
            __builder.AddMarkupContent(36, "<th class=\"w-20 bg-gray-300 border-l-2 border-r-2 border-black\"><div class=\"text-left\">View</div></th>");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
         foreach (var purchase in Purchases)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(40, 
#nullable restore
#line 24 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                purchase.Date.ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(44, 
#nullable restore
#line 25 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                purchase.ReferenceNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(48, 
#nullable restore
#line 26 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                purchase.VendorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "border-l-2 border-r-2 border-black");
            __builder.AddContent(52, 
#nullable restore
#line 27 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                purchase.Total.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "class", "border-l-2 border-r-2 border-black");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                   () => ShowEditPurchaseModal(purchase.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "border-l-2 border-r-2 border-black");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                   () => ShowDeletePurchaseModal(purchase.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "class", "border-l-2 border-r-2 border-black");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
                                                                                   () => RedirectViewPurchase(purchase.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "View");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<span>Loading...</span>");
#nullable restore
#line 38 "C:\Users\swarchuck\source\repos\InventoryManagement\InventoryManagement.Blazor\Pages\Purchases.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591