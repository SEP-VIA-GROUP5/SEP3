// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PaypalComponent
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
#line 9 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkoutnow/{GameName}")]
    public partial class CheckoutOneGame : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
       
    private string errorMessage;
    //TODO Design this page and make it for a specific game
    [Inject]
    IJSRuntime _jsRuntime { get; set; }

    [Parameter]
    public string GameName { get; set; }

    [CascadingParameter]
    public Task<AuthenticationState> AuthState { get; set; }

    private ClaimsPrincipal _claimsPrincipal;
    private string _username = "";

    private Game _game;
    private string _photoOfGame;

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            if (AuthState != null)
            {
                _claimsPrincipal = (await AuthState).User;
                _username = _claimsPrincipal.Identity.Name;
            }
            _game = await _gameService.getGameAsync(GameName);
            _photoOfGame = _game.GameName + ".png";
            SaveImageIntoClient();
        }
        catch (Exception e)
        {
            errorMessage = "Games not loaded or API still works...";
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        errorMessage = "";
        try
        {
            if (firstRender)
            {
                await _jsRuntime.InvokeVoidAsync("LoadButtonPaypal", Math.Round(@_game.Price, 2), _username);
            }
        }
        catch (Exception e)
        {
            errorMessage = "Games not loaded or API still works...";
        }
    }

    public void SaveImageIntoClient()
    {
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData(_game.Photo);
                File.WriteAllBytes($@"wwwroot/Images/Games/{_game.GameName}.png", dataArr);
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
    }
}
#pragma warning restore 1591
