// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages.Games
{
    #line hidden
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
#line 47 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using PaypalComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
using System.Net.Mime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Games\Index.razor"
 
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