#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "889966d81153d0019f7f3433bc2914c148d89f48"
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
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using System.Security.Cryptography.X509Certificates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Microsoft.VisualBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
using Microsoft.Extensions.Logging.Abstractions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReceiptMultipleGames/{Username}/{TransactionId}")]
    public partial class ReceiptMultipleGames : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 22 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
         if (User != null && GameCluster != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(2, "h3");
                __builder2.AddAttribute(3, "class", "text-center text-info");
                __builder2.AddContent(4, "Payment Successfully, number of games bought: ");
                __builder2.AddContent(5, 
#nullable restore
#line 24 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                             GameCluster.GamesStack.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "id", "smart-button-container");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container-fluid");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-10 mt-5 pt-5");
                __builder2.AddAttribute(15, "id", "color");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row shadow p-3");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-lg-4 rounded-left");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "card");
                __builder2.AddAttribute(22, "style", "width: 19rem;");
                __builder2.OpenElement(23, "img");
                __builder2.AddAttribute(24, "class", "card-img-top");
                __builder2.AddAttribute(25, "src", "Images/Games/" + (
#nullable restore
#line 32 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                     GetImage()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "style", "width: 30px; height: 30px");
                __builder2.AddAttribute(27, "alt", "Receipt Multiple Games photo");
                __builder2.AddAttribute(28, "title", "Congratulations! Thank you for your purchase");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "card-body");
                __builder2.OpenElement(32, "h3");
                __builder2.AddAttribute(33, "class", "card-title");
                __builder2.AddContent(34, "Receipt info - ");
                __builder2.AddContent(35, 
#nullable restore
#line 34 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                   GameCluster.GamesStack.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(36, " games bought");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                            ");
                __builder2.OpenElement(38, "ul");
                __builder2.AddAttribute(39, "class", "list-group list-group-flush");
                __builder2.OpenElement(40, "li");
                __builder2.AddAttribute(41, "class", "list-group-item");
                __builder2.OpenElement(42, "h3");
                __builder2.AddAttribute(43, "class", "font-weight-bold");
                __builder2.AddAttribute(44, "style", "font-weight: lighter");
                __builder2.AddMarkupContent(45, "\r\n                                                        Transaction ID: ");
                __builder2.AddContent(46, 
#nullable restore
#line 38 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
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
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-lg-8 bg-light");
                __builder2.AddMarkupContent(50, "<h3 class=\"mt-3 text-center\">Your information</h3>\r\n                                    <hr class=\"badge-primary mt-0 w-25\">\r\n                                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "row text-center");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "col-sm-6");
                __builder2.OpenElement(55, "h4");
                __builder2.AddAttribute(56, "class", "font-weight-bold");
                __builder2.AddContent(57, "First name: ");
                __builder2.AddContent(58, 
#nullable restore
#line 50 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                      User.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                        ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-sm-6");
                __builder2.OpenElement(62, "h4");
                __builder2.AddAttribute(63, "class", "font-weight-bold");
                __builder2.AddContent(64, "Last name: ");
                __builder2.AddContent(65, 
#nullable restore
#line 53 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                     User.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                    ");
                __builder2.AddMarkupContent(67, "<h3 class=\"mt-3\">Games bought</h3>\r\n                                    <hr class=\"badge-primary\">");
#nullable restore
#line 58 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                     foreach (var game in GameCluster.GamesStack)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "row text-center bg-light");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-sm-6");
                __builder2.OpenElement(72, "h4");
                __builder2.AddAttribute(73, "class", "font-weight-bold");
                __builder2.AddContent(74, "Game name: ");
                __builder2.AddContent(75, 
#nullable restore
#line 62 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                         game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                                            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-sm-6");
                __builder2.OpenElement(79, "h4");
                __builder2.AddAttribute(80, "class", "font-weight-");
                __builder2.AddContent(81, "Price: ");
                __builder2.AddContent(82, 
#nullable restore
#line 65 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                 Math.Round(game.Price, 2)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 68 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "text-center");
                __builder2.AddMarkupContent(85, "<h3 class=\"mt-3 text-center\">Get access</h3>\r\n                                        <hr class=\"badge-primary mt-0 w-25\">");
#nullable restore
#line 72 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                         if (keys.Count < 1)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(86, "button");
                __builder2.AddAttribute(87, "class", "btn btn-outline-success rounded");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                                                                      GetKey

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(89, "Generate keys");
                __builder2.CloseElement();
#nullable restore
#line 75 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                        }
                                        else
                                        {
                                            foreach (var key in keys)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(90, "h3");
                __builder2.AddContent(91, 
#nullable restore
#line 80 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                                     key

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 81 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 90 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "text-info text-center");
                __builder2.OpenElement(94, "h3");
                __builder2.AddContent(95, 
#nullable restore
#line 94 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
                     _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 96 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
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
#line 101 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\ReceiptMultipleGames.razor"
       

    [Parameter]
    public string Username { get; set; }

    [Parameter]
    public string GameName { get; set; }

    [Parameter]
    public string TransactionId { get; set; }

    private IList<string> keys = new List<string>();
    private string _key;
    //Variables for game and user to get receipt
    public GameCluster GameCluster { get; set; }
    public User User { get; set; }

    private string _errorMessage;

    protected override async Task OnInitializedAsync()
    {
        _errorMessage = "";
        try
        {
            GameCluster = await _gameService.getShoppingCartAsync(Username);
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
            foreach (var game in GameCluster.GamesStack)
                {
                    GameKey gameKey = await _gameService.getProductKeyAsync(game.GameId, Username);
                    _key = game.GameName + ": " + gameKey.Key;
                    keys.Add(_key);
                    GameCluster gameCluster = await _gameService.removeGameFromShoppingCartAsync(Username, game.GameId);
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
                byte[] dataArr = webClient.DownloadData("https://i.pinimg.com/736x/84/62/da/8462da46eeabbb94b0488b81a053e5bc.jpg");
                File.WriteAllBytes($@"wwwroot/Images/Other/ReceiptMultipleGames.png", dataArr);
            }
        }
    }

    public string GetImage()
    {
        SaveImageIntoClient();
        return "Images/Other/ReceiptMultipleGames.png";
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
