#pragma checksum "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06a1189fd0ab59b5ad1d958042fdf91f4054a8d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTutorial.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Shared.Entity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
      

    List<Movie> movies;

    protected async override Task OnInitializedAsync()
    {
        // wait 300 miliseconds
        await Task.Delay(300);


        movies = new List<Movie>()
        {
            new Movie() { Title = "Inception", ReleaseDate = new DateTime(2009, 1, 6) },
            new Movie() { Title = "Iron Man", ReleaseDate = new DateTime(2001, 1, 6) },
            new Movie() { Title = "Star War: Return of the Jedi", ReleaseDate = new DateTime(1995, 1, 6) },
            new Movie() { Title = "Thor: Dark World", ReleaseDate = new DateTime(2011, 11, 6) },
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
