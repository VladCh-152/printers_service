#pragma checksum "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15cad36125412c05d04c60c147d79fd3881c1156"
// <auto-generated/>
#pragma warning disable 1591
namespace PrintersFrontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using PrintersFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using PrintersFrontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using PrintersFrontend.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using PrintersFrontend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
using PrintersFrontend.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
 if (user == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PrintersFrontend.Components.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 15 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                     user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                           Authenticate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.AddMarkupContent(7, "<h6>e-mail</h6>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "InStyle");
                __builder2.AddAttribute(10, "id", "mail");
                __builder2.AddAttribute(11, "placeholder", "e-mail");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                                          user.Mail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Mail = __value, user.Mail))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Mail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.PrintersFrontend.Pages.Authentication.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 23 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                  () => user.Mail

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        <br>\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(19, "<h6>Пароль</h6>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "class", "InStyle");
                __builder2.AddAttribute(23, "id", "pass1");
                __builder2.AddAttribute(24, "placeholder", "пароль");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                                                           user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __Blazor.PrintersFrontend.Pages.Authentication.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 28 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                  () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\r\n        <br>");
#nullable restore
#line 30 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
         if (!isCorr)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(32, "<h6>Невеный пароль</h6>\r\n            <br>");
#nullable restore
#line 34 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(33, "<br>\r\n        ");
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(34);
                __builder2.AddAttribute(35, "Type", "submit");
                __builder2.AddAttribute(36, "Name", "Авторизоваться");
                __builder2.AddAttribute(37, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
                                                           250

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\Authentication.razor"
 
    private login_token auth;
    private AUser user;
    bool isCorr = true;

    protected override async Task OnInitializedAsync()
    {
        user = new AUser();
    }

    private async Task Authenticate()
    {
        isCorr = await _authService.AuthenticateAsync(user);
        await _printerService.LoadTokenAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrinterService _printerService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService _authService { get; set; }
    }
}
namespace __Blazor.PrintersFrontend.Pages.Authentication
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
