#pragma checksum "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4b8f7962ac2797af547c9ae73fb2b24b0ba67a"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 3 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!--- TODO Register page to be made next sprints ---!>\r\n\r\n\r\n\r\n<div class=\"wrapper\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row no-gutters");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-box ");
            __builder.AddMarkupContent(7, "<h1 class=\"font-weight-bold py-3\">Login</h1>\r\n            ");
            __builder.AddMarkupContent(8, "<h4>Sign into your account</h4>\r\n            ");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "class", "input-group");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "placeholder", "user name");
            __builder.AddAttribute(14, "class", "input-field");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                        newUserItem.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserItem.Username = __value, newUserItem.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "password");
            __builder.AddAttribute(20, "placeholder", "password");
            __builder.AddAttribute(21, "class", "input-field");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                           newUserItem.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserItem.Password = __value, newUserItem.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "placeholder", "first name");
            __builder.AddAttribute(28, "class", "input-field");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                         newUserItem.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserItem.FirstName = __value, newUserItem.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "placeholder", "last name");
            __builder.AddAttribute(35, "class", "input-field");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                        newUserItem.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserItem.LastName = __value, newUserItem.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "submit-btn");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                   AddNewUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "color:red");
            __builder.AddContent(47, 
#nullable restore
#line 22 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                         errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddMarkupContent(49, "<p>You arlready have an account? <a href=\"/login\">Login here</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\FACULTATE SEMESTRUL 3\SEP3\CODE\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
       
    private User newUserItem = new User();

    private string errorMessage;

    private void AddNewUser()
    {
        // UsersData.AddUser(newUserItem);
        // NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591