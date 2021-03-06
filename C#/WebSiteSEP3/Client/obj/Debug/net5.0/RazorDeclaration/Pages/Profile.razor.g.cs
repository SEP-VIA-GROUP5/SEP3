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
#line 2 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
using Client.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile/{Username}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 206 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Profile.razor"
       

    [Parameter]
    public string Username { get; set; }

    private string infoOneMessage;
    private string infoSecondMessage;
    private User user;
    private GameCluster gamesOwned;

    private Boolean changePasswordButton;
    private Boolean changeInformationsButton;

    protected override async Task OnParametersSetAsync()
    {
        infoOneMessage = "";
        try
        {
            user = await _userService.GetUser(Username);
            SaveImageIntoClient();
            gamesOwned = await _gameService.getLibraryAsync(Username);
            changePasswordButton = false;
            changeInformationsButton = false;
        }
        catch (Exception e)
        {
            infoOneMessage = "Informations are loading...";
            Console.WriteLine($"Profile Exception > {e.Message}");
        }
    }

    private async Task ChangePassword()
    {
        infoOneMessage = "";
        try
        {
            User verifyUser = await _userService.ChangePassword(user);
            if (verifyUser != null)
            {
                infoOneMessage = "Password changed!";
            }
            changePasswordButton = false;
            changeInformationsButton = false;
            if (!infoSecondMessage.Equals(""))
            {
                infoSecondMessage = "";
            }
            StateHasChanged();
        }
        catch (Exception e)
        {
            infoSecondMessage = "Password: something went wrong..";
            Console.WriteLine($"Profile Exception > {e.Message}");
        }
    }

    private async Task ChangeOtherInformation()
    {
        infoSecondMessage = "";
        try
        {
            User verifyUser = await _userService.EditUser(user);
            if (verifyUser != null)
            {
                infoSecondMessage = "Informations changed!";
            }
            if (!infoOneMessage.Equals(""))
            {
                infoOneMessage = "";
            }
            changeInformationsButton = false;
            changePasswordButton = false;
            StateHasChanged();
        }
        catch (Exception e)
        {
            infoSecondMessage = "Informations: something went wrong..";
            Console.WriteLine($"Profile Exception > {e.Message}");
        }
    }

    private void ButtonInformationButton()
    {
        changeInformationsButton = true;
        StateHasChanged();
    }

    private void ButtonPassword()
    {
        changePasswordButton = true;
        StateHasChanged();
    }


    public void SaveImageIntoClient()
    {
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData("https://pluspng.com/img-png/user-png-icon-thin-line-user-icon-2232.png");
                File.WriteAllBytes($@"wwwroot/Images/Users/userphoto.png", dataArr);
            }
        }
    }

    public void PerformWishlist()
    {
        _navigationManager.NavigateTo($"/Wishlist/{Username}");
    }

    public void PerformGameLibrary()
    {
        _navigationManager.NavigateTo($"/GameLibrary/{Username}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService _gameService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _userService { get; set; }
    }
}
#pragma warning restore 1591
