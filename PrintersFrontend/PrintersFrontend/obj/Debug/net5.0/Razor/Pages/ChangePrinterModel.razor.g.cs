#pragma checksum "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "919d8fe890e9e731dc3aa494d495473bad76dc93"
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
#line 2 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
using PrintersFrontend.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/model/{Id:int}")]
    public partial class ChangePrinterModel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
 if (changeModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<PrintersFrontend.Components.Loading>(0);
            __builder.CloseComponent();
#nullable restore
#line 12 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                  changeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                               EditModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.AddMarkupContent(7, "<h6>Vendor</h6>");
#nullable restore
#line 19 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
     if (vendors != null)
    {

#line default
#line hidden
#nullable disable
                __Blazor.PrintersFrontend.Pages.ChangePrinterModel.TypeInference.CreateInputSelect_0(__builder2, 8, 9, "InStyle", 10, "Vendor", 11, 
#nullable restore
#line 21 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                              changeModel.VendorId

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changeModel.VendorId = __value, changeModel.VendorId)), 13, () => changeModel.VendorId, 14, (__builder3) => {
#nullable restore
#line 22 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
             foreach (var vendor in vendors)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(15, "option");
                    __builder3.AddAttribute(16, "value", 
#nullable restore
#line 24 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                vendor.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(17, 
#nullable restore
#line 24 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                            vendor.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 25 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.PrintersFrontend.Pages.ChangePrinterModel.TypeInference.CreateValidationMessage_1(__builder2, 19, 20, 
#nullable restore
#line 27 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                  () => changeModel.VendorId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 28 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(21, "<h6>Type</h6>");
#nullable restore
#line 31 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
     if (types != null)
    {

#line default
#line hidden
#nullable disable
                __Blazor.PrintersFrontend.Pages.ChangePrinterModel.TypeInference.CreateInputSelect_2(__builder2, 22, 23, "InStyle", 24, "Type", 25, 
#nullable restore
#line 33 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                            changeModel.TypeId

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => changeModel.TypeId = __value, changeModel.TypeId)), 27, () => changeModel.TypeId, 28, (__builder3) => {
#nullable restore
#line 34 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
             foreach (var type in types)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(29, "option");
                    __builder3.AddAttribute(30, "value", 
#nullable restore
#line 36 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                type.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(31, 
#nullable restore
#line 36 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                          type.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 37 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(32, "\r\n        ");
                __Blazor.PrintersFrontend.Pages.ChangePrinterModel.TypeInference.CreateValidationMessage_3(__builder2, 33, 34, 
#nullable restore
#line 39 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                  () => changeModel.TypeId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 40 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "<br>\r\n    <br>");
#nullable restore
#line 43 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
     if (IsNew)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(36);
                __builder2.AddAttribute(37, "Type", "submit");
                __builder2.AddAttribute(38, "Name", "Добавить");
                __builder2.AddAttribute(39, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 45 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                     250

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(41);
                __builder2.AddAttribute(42, "Type", "button");
                __builder2.AddAttribute(43, "Name", "Назад");
                __builder2.AddAttribute(44, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                  250

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 46 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                                Back

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 47 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(46);
                __builder2.AddAttribute(47, "Type", "button");
                __builder2.AddAttribute(48, "Name", "Удалить модель");
                __builder2.AddAttribute(49, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 50 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                           250

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 50 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                                         RemoveModel

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(52);
                __builder2.AddAttribute(53, "Type", "submit");
                __builder2.AddAttribute(54, "Name", "Редактировать");
                __builder2.AddAttribute(55, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 51 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                          250

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenComponent<PrintersFrontend.Components.Button>(57);
                __builder2.AddAttribute(58, "Type", "button");
                __builder2.AddAttribute(59, "Name", "Назад");
                __builder2.AddAttribute(60, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                  250

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 52 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
                                                                Back

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 53 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 55 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\source\repos\PrintersFrontend\PrintersFrontend\Pages\ChangePrinterModel.razor"
 
    [Parameter]
    public int Id { get; set; }
    bool IsNew = false;

    private EditContext editContext;
    private PrinterModel changeModel;
    private List<Vendor> vendors;
    private List<PrinterType> types;

    protected override async Task OnInitializedAsync()
    {
        IsNew = false;
        if (Id == 0)
        {
            IsNew = true;
            changeModel = new PrinterModel();
        }
        else
        {
            changeModel = await Http.GetFromJsonAsync<PrinterModel>("https://localhost:44337/api/printermodels/" + Id.ToString());

            if (changeModel.Id == 0)
            {
                Id = 0;
                IsNew = true;
            }
        }
        vendors = await Http.GetFromJsonAsync<List<Vendor>>("https://localhost:44337/api/vendors");
        types = await Http.GetFromJsonAsync<List<PrinterType>>("https://localhost:44337/api/printertypes");
    }

    private async Task EditModel()
    {
        if (IsNew)
        {
            await Http.PostAsJsonAsync("https://localhost:44337/api/printermodels", changeModel);
        }
        else
        {
            await Http.PutAsJsonAsync($"https://localhost:44337/api/printermodels", changeModel);
        }
    }

    private void Back()
    {
        navigationManager.NavigateTo("https://localhost:44382/models");
    }

    private async Task RemoveModel()
    {
        await Http.DeleteAsync($"https://localhost:44337/api/printermodels/{changeModel.Id}");
        changeModel = new PrinterModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.PrintersFrontend.Pages.ChangePrinterModel
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
