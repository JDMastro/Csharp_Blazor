#pragma checksum "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68be4145c53fd56520fc92a97e2dc7ee4face0b6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFront.Pages.Empleados
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/empleados/form")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/empleados/form/{Id:int}")]
    public partial class EmpleadosForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmpleadosForm</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                  trabajadores

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container-fluid");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-sm-12 col-md-6");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "placeholder", "Nombres");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                  trabajadores.Nombres

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.Nombres = __value, trabajadores.Nombres))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trabajadores.Nombres));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "Apellido");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                  trabajadores.Apellidos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.Apellidos = __value, trabajadores.Apellidos))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trabajadores.Apellidos));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Direccion");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                  trabajadores.Direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.Direccion = __value, trabajadores.Direccion))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trabajadores.Direccion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Telefono");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                  trabajadores.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.Telefono = __value, trabajadores.Telefono))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trabajadores.Telefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n            ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-sm-12 col-md-6");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
#nullable restore
#line 38 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                     if (ListAreasRespuesta.Exito > 0)
                    {

#line default
#line hidden
#nullable disable
                __Blazor.BlazorFront.Pages.Empleados.EmpleadosForm.TypeInference.CreateInputSelect_0(__builder2, 50, 51, "area", 52, "form-control", 53, "Area", 54, 
#nullable restore
#line 40 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                                  trabajadores.AreasId

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.AreasId = __value, trabajadores.AreasId)), 56, () => trabajadores.AreasId, 57, (__builder3) => {
#nullable restore
#line 41 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                             foreach (var item in (List<Areas>)ListAreasRespuesta.Data)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(58, "option");
                    __builder3.AddAttribute(59, "value", 
#nullable restore
#line 43 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(60, 
#nullable restore
#line 43 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                          item.Descripcion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 44 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                }

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 46 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group");
                __Blazor.BlazorFront.Pages.Empleados.EmpleadosForm.TypeInference.CreateInputDate_1(__builder2, 64, 65, "form-control", 66, 
#nullable restore
#line 52 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                  trabajadores.FechaIngreso

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.FechaIngreso = __value, trabajadores.FechaIngreso)), 68, () => trabajadores.FechaIngreso);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __Blazor.BlazorFront.Pages.Empleados.EmpleadosForm.TypeInference.CreateInputSelect_2(__builder2, 72, 73, "area", 74, "form-control", 75, "Area", 76, 
#nullable restore
#line 56 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                              trabajadores.Sexo

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.Sexo = __value, trabajadores.Sexo)), 78, () => trabajadores.Sexo, 79, (__builder3) => {
                    __builder3.AddMarkupContent(80, "<option value=\"Masculino\">Masculino</option>\r\n                        ");
                    __builder3.AddMarkupContent(81, "<option value=\"Femenino\">Femenino</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
#nullable restore
#line 64 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                     if (ListAreasRespuesta.Exito > 0)
                    {

#line default
#line hidden
#nullable disable
                __Blazor.BlazorFront.Pages.Empleados.EmpleadosForm.TypeInference.CreateInputSelect_3(__builder2, 85, 86, "area", 87, "form-control", 88, "Area", 89, 
#nullable restore
#line 66 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                                                  trabajadores.EmpresasId

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trabajadores.EmpresasId = __value, trabajadores.EmpresasId)), 91, () => trabajadores.EmpresasId, 92, (__builder3) => {
#nullable restore
#line 67 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                             foreach (var item in (List<Empresas>)ListEmpresasRespuesta.Data)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(93, "option");
                    __builder3.AddAttribute(94, "value", 
#nullable restore
#line 69 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(95, 
#nullable restore
#line 69 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                                          item.Descripcion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 70 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                                }

#line default
#line hidden
#nullable disable
                }
                );
#nullable restore
#line 72 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\jdmlm\source\repos\BlazorFront\BlazorFront\Pages\Empleados\EmpleadosForm.razor"
       
    [Parameter]
    public int Id { get; set; }
    [Inject]
    public IAreas areasRepo { get; set; }

    [Inject]
    public IEmpresas empresasRepo { get; set; }

    public Respuesta<List<Areas>> ListAreasRespuesta = new Respuesta<List<Areas>>();
    public Respuesta<List<Empresas>> ListEmpresasRespuesta = new Respuesta<List<Empresas>>();

    Trabajadores trabajadores = new Trabajadores();
    Areas areas = new Areas();

    protected override async Task OnInitializedAsync()
    {
        await getAreasAndEmpresas();


        trabajadores.AreasId = ListAreasRespuesta.Data.FirstOrDefault().Id;
        trabajadores.Sexo = "Masculino";
        trabajadores.EmpresasId = ListEmpresasRespuesta.Data.FirstOrDefault().Id;
        //return base.OnInitializedAsync();
    }

    private async Task getAreasAndEmpresas()
    {
        ListAreasRespuesta = await areasRepo.GetAll("areas/jefes");
        ListEmpresasRespuesta = await empresasRepo.GetAll("empresas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
namespace __Blazor.BlazorFront.Pages.Empleados.EmpleadosForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
