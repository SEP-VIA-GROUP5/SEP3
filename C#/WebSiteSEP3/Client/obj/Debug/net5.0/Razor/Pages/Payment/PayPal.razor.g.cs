#pragma checksum "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PayPal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea52263b73bb19db638cd95615f5af27b04f6bb"
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
#line 1 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PayPal.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PayPal.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PayPal.razor"
using Microsoft.Extensions.Logging.Abstractions;

#line default
#line hidden
#nullable disable
    public partial class PayPal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"paypal-button-container\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\ljusk\Documents\GitHub\SEP3\C#\WebSiteSEP3\Client\Pages\Payment\PayPal.razor"
       
    private string errorMessage;
    //TODO Design this page and make it for a specific game
    [Inject]
    IJSRuntime _jsRuntime { get; set; }

    [Parameter]
    public string? GameName { get; set; }

    [Parameter]
    public string Username { get; set; }

    public Game game { get; set; }
    public GameCluster GameCluster { get; set; }

    protected override async Task OnInitializedAsync()
    {
        errorMessage = "";
        try
        {
            if (GameName != null)
            {
                game = await GameService.getGameAsync(GameName);
                await OnAfterRenderAsync(true);
            }
            else
            {
                GameCluster = await GameService.getShoppingCartAsync(Username);
                await OnAfterRenderAsync(true);
            }
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
                if (game != null)
                {
                    await _jsRuntime.InvokeVoidAsync("LoadButtonPaypal", Math.Round(@game.Price, 2), Username);
                }
                else
                {
                    if (GameCluster != null)
                    {
                        await _jsRuntime.InvokeVoidAsync("LoadButtonPaypal", Math.Round(GetTotalPrice(GameCluster), 2), Username);
                    }
                }
            }
        }
        catch (Exception e)
        {
            errorMessage = "Games not loaded or API still works...";
        }
    }

    public double GetTotalPrice(GameCluster gameCluster)
    {
        errorMessage = "";
        double value = 0;
        if (GameCluster != null)
        {
            foreach (var game in gameCluster.GamesStack)
            {
                value += game.Price;
            }
        }
        return value;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGameService GameService { get; set; }
    }
}
#pragma warning restore 1591
