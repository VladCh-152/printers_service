// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrintersFrontend.Components
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
    public partial class Button : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "D:\source\repos\PrintersFrontend\PrintersFrontend\Components\Button.razor"
       
    [Parameter]
    public string Type { get; set; }

    [Parameter]
    public string Name { get; set; }

    [Parameter]
    public int Width { get; set; }

    [Parameter]
    public bool IsActive { get; set; }

    [Parameter]
    public bool HasActive { get; set; }

    [Parameter]
    public EventCallback<string> OnClick { get; set; }

    private async Task CallOnClick()
    {
        if (HasActive) IsActive = true;

        if (OnClick.HasDelegate)
        {
            await OnClick.InvokeAsync();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591