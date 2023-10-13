#pragma checksum "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "742f55f94a036fc53d8311d1bbc8bdd9685dad99907bd1adf4897dccccdd5564"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
#nullable restore
#line 1 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "th");
            __builder.AddAttribute(7, "colspan", "5");
            __builder.AddAttribute(8, "class", "text-center");
#nullable restore
#line 3 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(9, TableTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 6 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
     if (Orders?.Count() > 0) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
         foreach (var o in Orders) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 9 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(18, o.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(19, "td");
#nullable restore
#line 9 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(20, o.Zip);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "<th>Product</th>");
            __builder.AddMarkupContent(22, "<th>Quantity</th>\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
                                    e => OrderSelected.InvokeAsync(o.OrderID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\n                    ");
#nullable restore
#line 13 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(29, ButtonLabel);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
#nullable restore
#line 17 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
             foreach (var line in o.Lines) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "                ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\n                    <td colspan=\"2\"></td>\n                    ");
            __builder.OpenElement(37, "td");
#nullable restore
#line 20 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(38, line.Product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(39, "td");
#nullable restore
#line 20 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
__builder.AddContent(40, line.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    <td></td>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n");
#nullable restore
#line 23 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
         
    } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.AddMarkupContent(44, "<tr><td colspan=\"5\" class=\"text-center\">No Orders</td></tr>\n");
#nullable restore
#line 27 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "/home/rugewit/Programming/CSharp/SportsSlnChapter11/SportsStore/Pages/Admin/OrderTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Order> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";

    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591