// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\ShoppingCart.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\ShoppingCart.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\ShoppingCart.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ShoppingCart")]
    public partial class ShoppingCart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\ShoppingCart.razor"
       
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
            _gameCluster = await GameService.getShoppingCartAsync(username);
        }
        catch (Exception e)
        {
            Console.WriteLine(errorMessage = e.Message);
            Console.WriteLine("Error while getting shopping cart");
        }
    }

    public double getTotalPrice()
    {
        double total = 0;
        foreach (var game in _gameCluster.GamesStack)
        {
            total += game.Price;
        }
        return total;
    }
    
    public async Task removeFromCart(int gameId)
    {
        try
        {
            await GameService.removeGameFromShoppingCartAsync(username, gameId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Exception when removing from shopping cart");
        }
    }

    public async Task buyAll()
    {
        //TODO later
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591