#pragma checksum "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2160823da29371ed7be70ed17b4b366e6710be8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SnowboardHireHRM.ComponentsLibrary.Map
{
    #line hidden
    using System.Linq;
#line 1 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using System;

#line default
#line hidden
#line 2 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using System.Collections.Generic;

#line default
#line hidden
#line 3 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using System.Threading.Tasks;

#line default
#line hidden
#line 4 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 5 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
using SnowboardHireHRM.ComponentsLibrary.Map;

#line default
#line hidden
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 11 "C:\Code\SnowboardHireHRM.Server\SnowboardHireHRM.ComponentsLibrary\Map\Map.razor"
       

    string elementId = $"map-{Guid.NewGuid().ToString("D")}";
    
    [Parameter] 
    public double Zoom { get; set; }

    [Parameter] 
    public List<Marker> Markers { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync(
            "deliveryMap.showOrUpdate",
            elementId,
            Markers);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
