#pragma checksum "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ce7f77fb9762390ce20a0eead8b380c565f57d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFront.Pages.Areas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront.Models.Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/areas/form")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/areas/form/{Id:int}")]
    public partial class AreaForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AreaForm</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor"
                  area

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor"
                                        Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container-fluid");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-10");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label asp-for=\"Descripcion\" class=\"control-label\"></label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor"
                                                                  area.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => area.Descripcion = __value, area.Descripcion))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => area.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __Blazor.BlazorFront.Pages.Areas.AreaForm.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 14 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor"
                                              ()=> area.Descripcion 

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n\r\n\r\n                ");
                __builder2.AddMarkupContent(25, "<div class=\"form-group\"><button type=\"submit\">Guardar</button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Areas\AreaForm.razor"
       
    [Parameter]
    public int Id { get; set; }

    Areas area = new Areas();
    [Inject]
    public IAreas areasRepo { get; set; }

    public Respuesta<Areas> oRespuesta = new Respuesta<Areas>();

    private async Task Guardar()
    {
            if(Id != 0) {
                var response = await areasRepo.Update("areas/", area, Id);
                oRespuesta = response;
                navigation.NavigateTo("/areas");

            } else {
                var response = await areasRepo.Store("areas", area);
                oRespuesta = response;
                navigation.NavigateTo("/areas");
            }
    }

    protected override async Task OnInitializedAsync()
    {
        if(Id != 0)
        {
            oRespuesta = await areasRepo.Get("areas/", Id);
            area = oRespuesta.Data;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
namespace __Blazor.BlazorFront.Pages.Areas.AreaForm
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
    }
}
#pragma warning restore 1591
