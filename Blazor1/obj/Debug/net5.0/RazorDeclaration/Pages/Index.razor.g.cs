// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Blazor1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Blazor1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Blazor1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\_Imports.razor"
using Blazor1.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Pages\Index.razor"
using Microsoft.VisualBasic;

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
#line 21 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Pages\Index.razor"
       

    List<Page> pages;

    Random rnd; 
    Page onePageToShow;
   
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        pages = new List<Page>()
        {
            new Page()
            {
                Name = "My first project",
                Level = "junior",
                ReleaseDate = new DateTime(2021, 08, 19)
            },
            new Page()
            {
                Name = "My 108 project",
                Level = "Still junior",
                ReleaseDate = new DateTime(2021, 08, 30)
            },
            new Page()
            {
                Name = "My 1009 project",
                Level = "Also junior",
                ReleaseDate = new DateTime(2021, 09, 15)
            },
        };

        rnd = new Random(DateTime.Now.Millisecond);
        onePageToShow = pages[rnd.Next(0, pages.Count)];
    }

    void ShowNewPage()
    {
        onePageToShow = SwitchPage();
    }
    
    Page SwitchPage()
    {
        Page tempPage;

        if (pages.Count >= 2)
        {
            int iterator = rnd.Next(0, pages.Count);
            tempPage = pages[iterator];
        }
        else if (pages.Count == 1)
            tempPage = pages[0];
        else
            return new Page() {Name = "No items in array", ReleaseDate = DateTime.Now};
        
        return tempPage;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
