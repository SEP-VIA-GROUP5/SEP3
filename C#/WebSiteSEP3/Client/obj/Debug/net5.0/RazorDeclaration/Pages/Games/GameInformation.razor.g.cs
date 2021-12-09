// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages.Games
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
using System.Diagnostics.Eventing.Reader;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GameInformation/{GameName}")]
    public partial class GameInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\GameInformation.razor"
       

    private ClaimsPrincipal _claimsPrincipal;

    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; }

    private string _username;

    [Parameter]
    public string GameName { get; set; }

    [Inject]
    IJSRuntime JsRuntime { get; set; }

    private Game _game;
    private string _errorMessage;
    private Boolean disableButton = false;

    protected override async Task OnInitializedAsync()
    {
        _errorMessage = "";
        try
        {
            _game = await GameService.getGameAsync(GameName);
        }
        catch (Exception e)
        {
            _errorMessage = e.Message;
        }
    }

    protected override async void OnParametersSet()
    {
        _claimsPrincipal = (await AuthState).User;
        _username = _claimsPrincipal.Identity.Name;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (_game != null)
            {
                var value = Math.Round(_game.Price, 2);
                await JsRuntime.InvokeVoidAsync("LoadButtonPaypal", value, _game.GameName);
            }
        }
    }

    public string GetImage(Game game)
    {
        return $"Images/Games/{game.GameName}.png";
    }

    public void OrderNow()
    {
        NavigationManager.NavigateTo($"/checkoutnow/{_game.GameName}");
    }

    public async Task AddToShoppingCart(Game game)
    {
        try
        {
            var validation = await GameService.addGameToShoppingCartAsync(_username, game);
            if (validation)
            {
                NavigationManager.NavigateTo($"/");
            }
            else
                _errorMessage = "Game couldn't be added in shopping cart - Error";
        }
        catch (Exception e)
        {
            _errorMessage = "Game couldn't be added in shopping cart - Error";
        }

    }

    public async Task AddToWishlist(Game game)
    {
        await GameService.addGameToWishlistAsync(_username, game);
    }

    public void EditGame()
    {
        NavigationManager.NavigateTo($"/EditGame/{_game.GameName}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
