#pragma checksum "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e900b8ee08f265a6e0ab7c478993646ded4492"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Components.Card
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
#line 1 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
using BlazorServerApp.Components.Card.Model;

#line default
#line hidden
#nullable disable
    public partial class Card : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"/css/styles.css\" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "text");
            __builder.AddAttribute(3, "class", 
#nullable restore
#line 7 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
                (!string.IsNullOrEmpty(Model.Value) && IsDisabled ? "disabled_card" : string.Empty)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "value", 
#nullable restore
#line 8 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
               Model.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
                   (ChangeEventArgs value) => Model.SetValue(value)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 10 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
                HandleBlur

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
                 HandleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\Components\Card\Card.razor"
       
    [Parameter]
    public CardModel Model { get; set; }

    private bool IsDisabled { get; set; }

    public void HandleBlur()
    {
        IsDisabled = true;
    }

    public void HandleClick()
    {
        IsDisabled = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
