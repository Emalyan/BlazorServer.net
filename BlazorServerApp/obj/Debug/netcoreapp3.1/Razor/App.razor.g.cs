#pragma checksum "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bff34692ba6f8f2a5f4f84a73c6e68c1546ba245"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp
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
#line 3 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\App.razor"
using BlazorServerApp.Components.Table;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>App</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\App.razor"
                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Hello");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "h1");
            __builder.AddContent(6, "Current count: ");
            __builder.AddContent(7, 
#nullable restore
#line 7 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\App.razor"
                    currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n<component type=\"typeof(Table)\" render-mode=\"ServerPrerendered\"></component>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\Blazor\Server\BlazorServerApp\BlazorServerApp\App.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;

        if(currentCount == 15)
        {
            currentCount = 0;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
