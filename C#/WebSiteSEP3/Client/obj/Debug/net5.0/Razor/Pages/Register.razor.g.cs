#pragma checksum "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31aa3b5032c25488730980a323a21794e613cba2"
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
#line 1 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
using Client.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!--- TODO Register page to be made next sprints ---!>\r\n\r\n\r\n\r\n<div class=\"wrapper\" b-aqp40rujkq></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-aqp40rujkq");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row no-gutters");
            __builder.AddAttribute(6, "b-aqp40rujkq");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-box");
            __builder.AddAttribute(9, "id", "function");
            __builder.AddAttribute(10, "b-aqp40rujkq");
            __builder.AddMarkupContent(11, "<h1 class=\"font-weight-bold py-3\" b-aqp40rujkq>Register</h1>\r\n            ");
            __builder.AddMarkupContent(12, "<h4 b-aqp40rujkq>Register new account</h4>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                             _user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "input-group");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "placeholder", "user name");
                __builder2.AddAttribute(20, "class", "input-field");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                        _user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Username = __value, _user.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(23, "b-aqp40rujkq");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "password");
                __builder2.AddAttribute(27, "placeholder", "password");
                __builder2.AddAttribute(28, "class", "input-field");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                           _user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Password = __value, _user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(31, "b-aqp40rujkq");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "placeholder", "first name");
                __builder2.AddAttribute(36, "class", "input-field");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                         _user.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.FirstName = __value, _user.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(39, "b-aqp40rujkq");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "text");
                __builder2.AddAttribute(43, "placeholder", "last name");
                __builder2.AddAttribute(44, "class", "input-field");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                                        _user.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.LastName = __value, _user.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(47, "b-aqp40rujkq");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "submit-btn");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                                               AddNewUserAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "b-aqp40rujkq");
            __builder.AddContent(54, "Register");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
             if (!_errorMessage.Equals(""))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "color:red");
            __builder.AddAttribute(57, "b-aqp40rujkq");
            __builder.AddContent(58, 
#nullable restore
#line 28 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
                                         _errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<div class=\"oi-info text-info\" b-aqp40rujkq><p b-aqp40rujkq>Already have an account? <a href=\"/login\" b-aqp40rujkq>Log in here</a></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\rytis\Desktop\Everything with uni\Programming\SEP projects\SEP3\SEP3\C#\WebSiteSEP3\Client\Pages\Register.razor"
       
    private User _user = new User();
    private string _errorMessage = "";

    private async void AddNewUserAsync()
    {
        try
        {
            User registeredUser = await UserService.RegisterUserAsync(_user.Username, _user.Password, _user.FirstName, _user.LastName);
            if (registeredUser != null)
            {
                NavigationManager.NavigateTo("/login");
            }
            else
            {
                _errorMessage = "error";
                throw new Exception("Failed to register - username already exist");
                
            }

        }
        catch (Exception e)
        {
            _errorMessage = e.Message;
            Console.WriteLine(e.Message);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
