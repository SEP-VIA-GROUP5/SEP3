#pragma checksum "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e84da4b3f2b14beae13cc2735c3cd2d0d5a95899"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameLibrary")]
    public partial class GameLibary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "panel panel-info");
            __builder.AddMarkupContent(2, "<div class=\"panel-heading\"><h3 class=\"panel-title\">Purchased Games Library</h3></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "panel-body");
            __builder.AddMarkupContent(5, "<div id=\"update-message\"></div>\r\n        ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped table-hover ");
            __builder.AddMarkupContent(8, "<thead><tr><th>\r\n                    Game Name\r\n                </th>\r\n                <th>\r\n                    Game Key\r\n                </th>\r\n                <th></th></tr></thead>");
#nullable restore
#line 25 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
             if (_gameCluster != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                 foreach (var game in _gameCluster.GamesStack)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 31 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                             game.GameName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                             game.GameKey.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
             if (_gameCluster == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<div class=\"custom-bg\"><p>You have not purchased a game yet. Go buy one!</p></div>");
#nullable restore
#line 44 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\GameLibary.razor"
       
    GameCluster _gameCluster;

    string errorMessage ="";

    private ClaimsPrincipal _claimsPrincipal;

    private User _user = new User();

    public string username { get; set; }

    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; }

    protected override async void OnParametersSet()
    {
        if (AuthState != null)
        {
            _claimsPrincipal = (await AuthState).User;
            username = _claimsPrincipal.Identity.Name;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            OnParametersSet();
            _gameCluster = await GameService.getLibraryAsync(username);
        }
        catch (Exception e)
        {
            Console.WriteLine(errorMessage = e.Message);
            Console.WriteLine("Error while getting game library");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
