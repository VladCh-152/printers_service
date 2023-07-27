// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
