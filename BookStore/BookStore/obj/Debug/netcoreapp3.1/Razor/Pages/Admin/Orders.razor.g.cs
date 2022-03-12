#pragma checksum "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4270d084a92603c1425553b14de62da5109e60b6"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BookStore.Pages.Admin.OrdersTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Shipped Orders");
            __builder.AddAttribute(2, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BookStore.Models.Purchase>>(
#nullable restore
#line 4 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
                                                 ShippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Reset");
            __builder.AddAttribute(4, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 4 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
                                                                                                   ResetOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<BookStore.Pages.Admin.OrdersTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Unfulfilled Orders");
            __builder.AddAttribute(8, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<BookStore.Models.Purchase>>(
#nullable restore
#line 5 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
                                                     UnfulfilledOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Ship");
            __builder.AddAttribute(10, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 5 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
                                                                                                          ShipOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
                                         x => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Data");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
       
    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllOrders { get; set; }
    public IEnumerable<Purchase> ShippedOrders { get; set; }
    public IEnumerable<Purchase> UnfulfilledOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Purchases.ToListAsync();
        ShippedOrders = AllOrders.Where(x => x.OrderShipped);
        UnfulfilledOrders = AllOrders.Where(x => !x.OrderShipped);
    }

    public void ShipOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false);

    private void UpdateOrder(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.OrderShipped = shipped;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591