#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8ffe9b679b0894e05246494f0ab5a27604e3fc8"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages.Payment
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
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using System.Security.Cryptography.X509Certificates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Microsoft.VisualBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
using Microsoft.Extensions.Logging.Abstractions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReceiptOneGame/{Username}/{GameName}/{TransactionId}")]
    public partial class ReceiptOneGame : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "h3");
                __builder2.AddAttribute(3, "class", "text-center text-info");
                __builder2.AddContent(4, "Payment Successfully, game: ");
                __builder2.AddContent(5, 
#nullable restore
#line 19 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                       GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 20 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
         if (User != null && Game != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "id", "smart-button-container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "container-fluid");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-10 mt-5 pt-5");
                __builder2.AddAttribute(14, "id", "color");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row shadow p-3");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-lg-4 rounded-left");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "card");
                __builder2.AddAttribute(21, "style", "width: 19rem;");
                __builder2.OpenElement(22, "img");
                __builder2.AddAttribute(23, "class", "card-img-top");
                __builder2.AddAttribute(24, "src", "Images/Games/" + (
#nullable restore
#line 29 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                     GetImage()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "alt", "Image of shopping cart");
                __builder2.AddAttribute(26, "title", "Buy" + " " + (
#nullable restore
#line 29 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                                                                          GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                                        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "card-body");
                __builder2.OpenElement(30, "h3");
                __builder2.AddAttribute(31, "class", "card-title");
                __builder2.AddContent(32, "Receipt info ");
                __builder2.AddContent(33, 
#nullable restore
#line 31 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                 GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                                            ");
                __builder2.OpenElement(35, "ul");
                __builder2.AddAttribute(36, "class", "list-group list-group-flush");
                __builder2.OpenElement(37, "li");
                __builder2.AddAttribute(38, "class", "list-group-item");
                __builder2.OpenElement(39, "h3");
                __builder2.AddAttribute(40, "class", "font-weight-bold");
                __builder2.AddMarkupContent(41, "\r\n                                                        Transaction ID: ");
                __builder2.AddContent(42, 
#nullable restore
#line 35 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                         TransactionId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-lg-8 bg-light");
                __builder2.AddMarkupContent(46, "<h3 class=\"mt-3 text-center\">Your information</h3>\r\n                                    <hr class=\"badge-primary mt-0 w-25\">\r\n                                    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row text-center");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-sm-6");
                __builder2.OpenElement(51, "h4");
                __builder2.AddAttribute(52, "class", "font-weight-bold");
                __builder2.AddContent(53, "First name: ");
                __builder2.AddContent(54, 
#nullable restore
#line 47 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                      User.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-6");
                __builder2.OpenElement(58, "h4");
                __builder2.AddAttribute(59, "class", "font-weight-bold");
                __builder2.AddContent(60, "Last name: ");
                __builder2.AddContent(61, 
#nullable restore
#line 50 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                     User.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                    ");
                __builder2.AddMarkupContent(63, "<h3 class=\"mt-3 text-center\">Game bought</h3>\r\n                                    <hr class=\"badge-primary mt-0 w-25\">\r\n                                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "row text-center");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-sm-6");
                __builder2.OpenElement(68, "h4");
                __builder2.AddAttribute(69, "class", "font-weight-bold");
                __builder2.AddContent(70, "Game name: ");
                __builder2.AddContent(71, 
#nullable restore
#line 57 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                     Game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-sm-6");
                __builder2.OpenElement(75, "h4");
                __builder2.AddAttribute(76, "class", "font-weight-bold");
                __builder2.AddContent(77, "Price: ");
                __builder2.AddContent(78, 
#nullable restore
#line 60 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                 Math.Round(Game.Price, 2)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                                    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "text-center");
                __builder2.AddMarkupContent(82, "<h3 class=\"mt-3 text-center\">Get access</h3>\r\n                                        <hr class=\"badge-primary mt-0 w-25\">\r\n                                        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddContent(84, 
#nullable restore
#line 66 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                              _key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                                        ");
                __builder2.OpenElement(86, "button");
                __builder2.AddAttribute(87, "class", "btn btn-outline-success rounded");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                                                                                                  GetKey

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(89, "Generate key");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 75 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "text-info text-center");
                __builder2.OpenElement(92, "h3");
                __builder2.AddContent(93, 
#nullable restore
#line 79 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
                     _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 81 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptOneGame.razor"
       

    [Parameter]
    public string Username { get; set; }

    [Parameter]
    public string GameName { get; set; }

    [Parameter]
    public string TransactionId { get; set; }

    private string _key;
    //Variables for game and user to get receipt
    public Game Game { get; set; }
    public User User { get; set; }

    private string _errorMessage;

    protected override async Task OnInitializedAsync()
    {
        _errorMessage = "";
        try
        {
            Game = await _gameService.getGameAsync(GameName);
            SaveImageIntoClient();

            User = await _userService.GetUser(Username);
        }
        catch (Exception e)
        {
            _errorMessage = "Loading information...";
            Console.WriteLine(e.Message);
        }
    }

    public async Task GetKey()
    {
        try
        {
            if (_key != null)
            {
                _key += "\n You already got the key.";
            }
            else
            {
                GameKey gameKey = await _gameService.getProductKeyAsync(Game.GameId, Username);
                _key = gameKey.Key;
                var validationDelete = await _gameService.removeGameFromShoppingCartAsync(Username, Game.GameId);
                if (!validationDelete) throw new Exception("Couldn't delete the key - Error API");
            }
        }
        catch (Exception e)
        {
            _key = e.Message;
        }
    }

    //for getting the image
    public void SaveImageIntoClient()
    {
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData(Game.Photo);
                File.WriteAllBytes($@"wwwroot/Images/Games/{Game.GameName}.png", dataArr);
            }
        }
    }

    public string GetImage()
    {
        return $"Images/Games/{Game.GameName}.png";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
    }
}
#pragma warning restore 1591
