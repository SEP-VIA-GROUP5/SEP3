#pragma checksum "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a921ac4f44b42497d97c39e395650503b8f6196"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages.Games
{
    #line hidden
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
#line 5 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using PaypalComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Microsoft.AspNetCore.Mvc.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "text-info");
                __builder2.OpenElement(4, "h1");
                __builder2.AddContent(5, "Hi, ");
                __builder2.AddContent(6, 
#nullable restore
#line 18 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container row align-top float-right");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-lg-4");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "alt", "search for game");
                __builder2.AddAttribute(16, "style", "width: 150px");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                      searchedGameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchedGameName = __value, searchedGameName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "button");
                __builder2.AddAttribute(21, "class", "btn-outline-primary");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                () => FilterByGameName(searchedGameName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(23, "<i class=\"oi oi-eye\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "button");
                __builder2.AddAttribute(26, "class", "btn-outline-primary");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                              ClearSearch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Clear");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
         if (errorMessage.Equals(""))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "text-info");
#nullable restore
#line 34 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (searchedGameName == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<h1>Here are some games that might interest you</h1>");
#nullable restore
#line 37 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "h1");
                __builder2.AddContent(33, "Results for ");
                __builder2.AddContent(34, 
#nullable restore
#line 40 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                     searchedGameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "container-fluid row");
#nullable restore
#line 44 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (games != null)
                               {
                                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                    foreach (var game in games.GamesStack)
                                   {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-lg-4");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "card");
                __builder2.AddAttribute(42, "style", "width: 19rem");
                __builder2.OpenElement(43, "img");
                __builder2.AddAttribute(44, "class", "card-img-top");
                __builder2.AddAttribute(45, "src", 
#nullable restore
#line 50 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                               GetImage(game)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(46, "alt", "Image" + " of" + " " + (
#nullable restore
#line 50 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                                              game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "title", "Order" + " " + (
#nullable restore
#line 50 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                                                                           game.GameName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                               ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "card-body");
                __builder2.OpenElement(51, "h3");
                __builder2.AddAttribute(52, "class", "card-title");
                __builder2.AddContent(53, 
#nullable restore
#line 52 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                           game.GameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                                   ");
                __builder2.OpenElement(55, "ul");
                __builder2.AddAttribute(56, "class", "list-group list-group-flush");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "list-group-item");
                __builder2.AddMarkupContent(59, "\r\n                                                           $");
                __builder2.AddContent(60, 
#nullable restore
#line 55 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                             string.Format("{0:f}", Math.Round(game.Price, 2).ToString())

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                                                   ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "card-body row");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "class", "btn btn-sm btn-dark order-button float-lg-right");
                __builder2.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                                                                                                 (() => MoreInformations(game.GameName))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(67, "INFO");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 64 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                    
                               }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 67 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
            
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "text-info");
                __builder2.OpenElement(70, "h1");
                __builder2.AddContent(71, 
#nullable restore
#line 72 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                     errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 74 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(72, "nav");
                __builder2.AddAttribute(73, "class", "pagenavigation");
                __builder2.AddAttribute(74, "aria-label", "page navigation");
                __builder2.OpenElement(75, "ul");
                __builder2.AddAttribute(76, "class", "pagination");
#nullable restore
#line 81 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (pageNr != 0)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(77, "li");
                __builder2.AddAttribute(78, "class", "page-item");
                __builder2.OpenElement(79, "a");
                __builder2.AddAttribute(80, "class", "page-link");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(82, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 86 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else if (pageNr == 0 || errorMessage.Equals("") || searchedGameName != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(83, "li");
                __builder2.AddAttribute(84, "class", "page-item disabled");
                __builder2.OpenElement(85, "a");
                __builder2.AddAttribute(86, "class", "page-link");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       PreviousPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(88, "Previous");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 92 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                 if (errorMessage.Equals(""))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(89, "li");
                __builder2.AddAttribute(90, "class", "page-item");
                __builder2.OpenElement(91, "a");
                __builder2.AddAttribute(92, "class", "page-link");
                __builder2.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(94, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }
                else if (!errorMessage.Equals("") || searchedGameName != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(95, "li");
                __builder2.AddAttribute(96, "class", "page-item disabled");
                __builder2.OpenElement(97, "a");
                __builder2.AddAttribute(98, "class", "page-link");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                                                       NextPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(100, "Next");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 104 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(101, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LoginComponent.Login>(102);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
 
    private GameCluster games;
    private int pageNr = 0;
    private string errorMessage;


    private string? searchedGameName;

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    // TODO private void CheckOutNow(string gameName)
    // {
    //     NavigationManager.NavigateTo($"/Paypal/{gameName}");
    //
    // }

    private async Task PreviousPage()
    {
        errorMessage = "";
        try
        {
            pageNr--;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = "There are no games on this page..";
        }
    }

    private async Task NextPage()
    {
        errorMessage = "";
        try
        {
            pageNr++;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            await PreviousPage();
            pageNr++;
            errorMessage = "There are no games on this page..";
        }
    }

    public void SaveImageIntoClient(GameCluster gameCluster)
    {
        {
            foreach (var game in gameCluster.GamesStack)
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] dataArr = webClient.DownloadData(game.Photo);
                    File.WriteAllBytes($@"wwwroot/Images/Games/{game.GameName}.png", dataArr);
                }
            }
        }
    }

    public string GetImage(Game game)
    {
        return $"Images/Games/{game.GameName}.png";
    }

    private async Task FilterByGameName(string searchedGames)
    {
        errorMessage = "";
        try
        {
            if (searchedGames != null)
            {
                games = await _gameService.getSearchAsync(searchedGames);
                SaveImageIntoClient(games);
                if (games.GamesStack.Count == 0)
                {
                    errorMessage = $"There are no games for {searchedGames}";
                }
            }
            else
            {
                games = await _gameService.getGameClusterAsync(pageNr);
                SaveImageIntoClient(games);
            }
        }
        catch (Exception e)
        {
            errorMessage = $"There are no games for {searchedGames}";
        }
    }

    private async Task ClearSearch()
    {
        errorMessage = "";
        try
        {
            pageNr = 0;
            games = await _gameService.getGameClusterAsync(pageNr);
            SaveImageIntoClient(games);
        }
        catch (Exception e)
        {
            errorMessage = "There are no games on this page..";
        }
    }

    private void MoreInformations(string gameName)
    {
        NavigationManager.NavigateTo($"/GameInformation/{gameName}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
