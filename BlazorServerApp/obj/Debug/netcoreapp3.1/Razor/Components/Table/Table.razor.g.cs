#pragma checksum "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bda852e8c2017a59ff0f8533794416dd6399959"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Components.Table
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
using BlazorServerApp.Components.Card.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
using BlazorServerApp.Components.Table.Row.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Table</h3>\r\n\r\n");
#nullable restore
#line 10 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
 foreach (var row in Rows)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorServerApp.Components.Table.Row.Row>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorServerApp.Components.Table.Row.Models.RowModel>(
#nullable restore
#line 12 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
                                                      row

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 13 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
                  AddRow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Add Row");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Send Row");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Table\Table.razor"
       
    public List<RowModel> Rows = new List<RowModel>();

    public void AddRow()
    {
        Rows.Add(new RowModel());
    }

    public async void Send()
    {
        await JSRuntime.InvokeVoidAsync("send", Rows);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
