#pragma checksum "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0dee0a1625a06a7f48ea95193a8f567bbc096cf"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor1.Shared
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
#line 1 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
    public partial class PageListTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "table-responsive");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.OpenElement(4, "thead");
            __builder.AddAttribute(5, "class", "table-striped");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Name</th>    \r\n            ");
            __builder.AddMarkupContent(8, "<th>Level</th>\r\n            ");
            __builder.AddMarkupContent(9, "<th>ReleaseDate</th>\r\n            ");
            __builder.OpenElement(10, "th");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                              displayButtons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayButtons = __value, displayButtons));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tbody");
            __Blazor.Blazor1.Shared.PageListTable.TypeInference.CreateGenericList_0(__builder, 17, 18, 
#nullable restore
#line 13 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                  Pages

#line default
#line hidden
#nullable disable
            , 19, (onepage) => (__builder2) => {
                __builder2.OpenComponent<Blazor1.Shared.IndividualPage>(20);
                __builder2.AddAttribute(21, "Page", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor1.Models.Page>(
#nullable restore
#line 15 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                      onepage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "IsTable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "DisplayButtons", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                                                              displayButtons

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "DeletePage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Blazor1.Models.Page>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Blazor1.Models.Page>(this, 
#nullable restore
#line 15 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
                                                                                                          DeleteThePage

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\tymch\RiderProjects\Blazor1\Blazor1\Shared\PageListTable.razor"
       

    [Parameter] public List<Page> Pages { get; set; } //параметры должны быть публичными и pages долно быть с большой буквы
    
    bool displayButtons = false;

    void DeleteThePage(Page page)
    {
        Pages.Remove(page);//удалить рядом столбик 
    }

    protected override void OnInitialized()
    {
        Console.WriteLine($"1. OnInitialized(). Pages count: {Pages?.Count}.");// вопрос проверяет на нулл
    } 

    protected override void OnParametersSet()// переносит/выводит все параметры
    {
        Console.WriteLine($"2. OnParametersSet(). Pages count: {Pages?.Count}.");// вопрос проверяет на нулл
    }

    protected override void OnAfterRender(bool firstRender)//первый ли раз страница отрисовуется если вся страница то тру а если переисовывается только часть страници то фолс
    {
        Console.WriteLine($"3. OnAfterRender(bool firstRender). Does it first render: {firstRender}.");
    }

    protected override bool ShouldRender()//дает или отключает возможность перерисовки компонента
    {
        return true;//изменения разрешены
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Blazor1.Shared.PageListTable
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Blazor1.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ListOfItems", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
