#pragma checksum "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1089e6eb8eb2337f19f9dccd5bda46c2c74e3ef4"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-kd1ih0s86n");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-kd1ih0s86n>Client</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-kd1ih0s86n");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-kd1ih0s86n></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 11 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-kd1ih0s86n");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-kd1ih0s86n");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-kd1ih0s86n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-kd1ih0s86n></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-kd1ih0s86n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                PerformProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-kd1ih0s86n></span>Profile\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-kd1ih0s86n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                PerformShoppingCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-cart\" aria-hidden=\"true\" b-kd1ih0s86n></span>Shopping Cart\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item px-3");
            __builder.AddAttribute(47, "b-kd1ih0s86n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                PerformGameLibrary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-kd1ih0s86n></span>Game Library\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(54);
            __builder.AddAttribute(55, "Policy", "Administrator");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddAttribute(59, "b-kd1ih0s86n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "AddGame");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                                   PerformAddGame

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(65, "<span class=\"oi oi-laptop\" aria-hidden=\"true\" b-kd1ih0s86n></span>Add Game\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "li");
            __builder.AddAttribute(68, "class", "nav-item px-3");
            __builder.AddAttribute(69, "b-kd1ih0s86n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(70);
            __builder.AddAttribute(71, "class", "nav-link");
            __builder.AddAttribute(72, "href", "login");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
                                                             PerformLogout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(75, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-kd1ih0s86n></span>Log out\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Shared\NavMenu.razor"
       
    private string username;
    
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async void OnParametersSet()
    {
        var claimsPrincipal = (await AuthenticationStateProvider.GetAuthenticationStateAsync()).User;
        if (claimsPrincipal.Identity.IsAuthenticated)
        {
            username = claimsPrincipal.Identity.Name;
        }
    }
    
    public async Task PerformLogout()
    {
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            _navigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }

    public void PerformProfile()
    {
        _navigationManager.NavigateTo($"/Profile/{username}");
    }
    
    public void PerformShoppingCart()
    {
        _navigationManager.NavigateTo($"/ShoppingCart/{username}");
    }

    public void PerformGameLibrary()
    {
        _navigationManager.NavigateTo($"/GameLibrary/{username}");
    }

    public void PerformAddGame()
    {
        _navigationManager.NavigateTo("/AddGame");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
