#pragma checksum "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796f72066953ca3069cdd7b3b92ee06f2855ff04"
// <auto-generated/>
#pragma warning disable 1591
namespace PaypalComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
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
#nullable restore
#line 12 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
 if (_game != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "smart-button-container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row d-flex justify-content-center");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-10 mt-5 pt-5");
            __builder.AddAttribute(8, "id", "color");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row shadow p-3");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-4 rounded-left");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddAttribute(15, "style", "width: 19rem;");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "src", "Images/Games/" + (
#nullable restore
#line 21 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                                             _photoOfGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "alt", "Image of shopping cart");
            __builder.AddAttribute(20, "title", "Buy" + " " + (
#nullable restore
#line 21 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                                                                                                    GameName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "h3");
            __builder.AddAttribute(25, "class", "card-title");
            __builder.AddContent(26, "Checkout ");
            __builder.AddContent(27, 
#nullable restore
#line 23 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                                     GameName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "list-group list-group-flush");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "list-group-item");
            __builder.OpenElement(33, "h3");
            __builder.AddAttribute(34, "class", "font-weight-bold");
            __builder.AddMarkupContent(35, "\r\n                                                Price $");
            __builder.AddContent(36, 
#nullable restore
#line 27 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                        string.Format("{0:f}", Math.Round(_game.Price, 2).ToString())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-lg-8 bg-light");
            __builder.AddMarkupContent(40, "<h3 class=\"mt-3 text-center\">Checkout</h3>\r\n                            <hr class=\"badge-primary mt-0 w-25\">\r\n                            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "text-align: center");
            __builder.OpenComponent<PaypalComponent.PayPal>(43);
            __builder.AddAttribute(44, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                   _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "GameName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
                                                                         GameName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "h1");
            __builder.AddContent(47, 
#nullable restore
#line 49 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
         errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\titas\Desktop\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\CheckoutOneGame.razor"
       
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
