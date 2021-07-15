// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591