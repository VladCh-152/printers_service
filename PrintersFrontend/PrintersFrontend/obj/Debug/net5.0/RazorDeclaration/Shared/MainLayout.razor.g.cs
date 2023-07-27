// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrintersFrontend.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\source\repos\PrintersFrontend\PrintersFrontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
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
#line 2 "D:\source\repos\PrintersFrontend\PrintersFrontend\Shared\MainLayout.razor"
using PrintersFrontend.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\source\repos\PrintersFrontend\PrintersFrontend\Shared\MainLayout.razor"
       
    private bool _hasAccess;
    private string _userName;
    private string _role;

    protected override async Task OnInitializedAsync()
    {
        await Auth();
    }

    protected override async Task OnParametersSetAsync()
    {
        await Auth();
    }

    private async Task LogOut()
    {
        await authService.LogOut();
        _userName = string.Empty;
        _role = "Guest";
        _hasAccess = false;
    }

    private async Task ToRegistration()
    {
        navigationManager.NavigateTo("https://localhost:44382/registration");
        this.StateHasChanged();
        Console.WriteLine(_hasAccess);
    }

    private async Task ToLogin()
    {
        navigationManager.NavigateTo("https://localhost:44382/authentication");
        this.StateHasChanged();
        Console.WriteLine(_hasAccess);
    }

    private async Task Auth()
    {
        _hasAccess = false;
        _userName = await authService.GetNameAsync();
        _role = await authService.GetRoleAsync();
        string path = new Uri(navigationManager.Uri).AbsolutePath.ToLower();
        Console.WriteLine(path);
        var guestUris = new string[] { "/authentication", "/registration" };
        var userRestrictedUris = new string[] { "/admin" };

        if (_role == "Admin")
        {
            _hasAccess = true;
        }
        foreach (string a in guestUris)
        {
            if (path == a)
            {
                _hasAccess = true;
            }
        }
        if (_role == "User")
        {
            _hasAccess = true;
            foreach (string a in userRestrictedUris)
            {
                if (path.Contains(a))
                {
                    _hasAccess = false;
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthService authService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
