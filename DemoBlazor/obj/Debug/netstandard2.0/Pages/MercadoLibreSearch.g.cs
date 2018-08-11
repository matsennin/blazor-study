#pragma checksum "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da7d97b3c6cf62148b4abd0a9f20445f4a9f108"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using DemoBlazor;
    using DemoBlazor.Shared;
    using DemoBlazor.Classes;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/mercadolibre/search")]
    public class MercadoLibreSearch : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Product Search on Mercado Libre");
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "p");
            builder.AddContent(4, "This component demonstrates fetching data from a 3rd party API.");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenElement(6, "p");
            builder.AddContent(7, "\n    ");
            builder.OpenElement(8, "form");
            builder.AddContent(9, "\n        ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "form-group");
            builder.AddContent(12, "\n            ");
            builder.OpenElement(13, "label");
            builder.AddAttribute(14, "for", "query");
            builder.AddAttribute(15, "class", "control-label");
            builder.AddContent(16, "Query");
            builder.CloseElement();
            builder.AddContent(17, "\n            ");
            builder.OpenElement(18, "input");
            builder.AddAttribute(19, "name", "query");
            builder.AddAttribute(20, "class", "form-control");
            builder.AddAttribute(21, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(querySearch));
            builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => querySearch = __value, querySearch));
            builder.CloseElement();
            builder.AddContent(23, "\n        ");
            builder.CloseElement();
            builder.AddContent(24, "\n        ");
            builder.OpenElement(25, "div");
            builder.AddAttribute(26, "class", "form-group");
            builder.AddContent(27, "\n            ");
            builder.OpenElement(28, "button");
            builder.AddAttribute(29, "type", "button");
            builder.AddAttribute(30, "class", "btn btn-primary");
            builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(Search));
            builder.AddContent(32, "Search");
            builder.CloseElement();
            builder.AddContent(33, "\n        ");
            builder.CloseElement();
            builder.AddContent(34, "\n    ");
            builder.CloseElement();
            builder.AddContent(35, "\n");
            builder.CloseElement();
            builder.AddContent(36, "\n");
#line 20 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml"
 if (searchResult != null)
{

#line default
#line hidden
            builder.AddContent(37, "    ");
            builder.OpenElement(38, "table");
            builder.AddAttribute(39, "class", "table");
            builder.AddContent(40, "\n        ");
            builder.OpenElement(41, "thead");
            builder.AddContent(42, "\n            ");
            builder.OpenElement(43, "tr");
            builder.AddContent(44, "\n                ");
            builder.OpenElement(45, "td");
            builder.AddContent(46, "Link");
            builder.CloseElement();
            builder.AddContent(47, "\n                ");
            builder.OpenElement(48, "th");
            builder.AddContent(49, "Site");
            builder.CloseElement();
            builder.AddContent(50, "\n                ");
            builder.OpenElement(51, "th");
            builder.AddContent(52, "Title");
            builder.CloseElement();
            builder.AddContent(53, "\n                ");
            builder.OpenElement(54, "th");
            builder.AddContent(55, "Condition");
            builder.CloseElement();
            builder.AddContent(56, "\n                ");
            builder.OpenElement(57, "th");
            builder.AddContent(58, "Price");
            builder.CloseElement();
            builder.AddContent(59, "\n            ");
            builder.CloseElement();
            builder.AddContent(60, "\n        ");
            builder.CloseElement();
            builder.AddContent(61, "\n        ");
            builder.OpenElement(62, "tbody");
            builder.AddContent(63, "\n            ");
            builder.AddContent(64, querySearch);
            builder.AddContent(65, "\n");
#line 34 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml"
             foreach (var item in searchResult.results)
            {

#line default
#line hidden
            builder.AddContent(66, "                ");
            builder.OpenElement(67, "tr");
            builder.AddContent(68, "\n                    ");
            builder.OpenElement(69, "td");
            builder.OpenElement(70, "a");
            builder.AddAttribute(71, "target", "_blank");
            builder.AddAttribute(72, "href", item.permalink);
            builder.AddContent(73, "View");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddContent(74, "\n                    ");
            builder.OpenElement(75, "td");
            builder.AddContent(76, item.site_id);
            builder.CloseElement();
            builder.AddContent(77, "\n                    ");
            builder.OpenElement(78, "td");
            builder.AddContent(79, item.title);
            builder.CloseElement();
            builder.AddContent(80, "\n                    ");
            builder.OpenElement(81, "td");
            builder.AddContent(82, item.condition);
            builder.CloseElement();
            builder.AddContent(83, "\n                    ");
            builder.OpenElement(84, "td");
            builder.AddContent(85, "R$ ");
            builder.AddContent(86, item.price);
            builder.CloseElement();
            builder.AddContent(87, "\n                ");
            builder.CloseElement();
            builder.AddContent(88, "\n");
#line 43 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml"
            }

#line default
#line hidden
            builder.AddContent(89, "        ");
            builder.CloseElement();
            builder.AddContent(90, "\n    ");
            builder.CloseElement();
            builder.AddContent(91, "\n");
#line 46 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 48 "C:\Users\caval\Documents\Visual Studio 2017\Projects\Repositories\blazor-study\DemoBlazor\Pages\MercadoLibreSearch.cshtml"
            
    string querySearch;
    ItemSearchResult searchResult = new ItemSearchResult();

    protected async Task Search()
    {
        searchResult = await Http.GetJsonAsync<ItemSearchResult>($"https://api.mercadolibre.com/sites/MLB/search?q={querySearch}");
        querySearch = new DemoBlazor.Classes.MercadoLibreSearch().Ola();
    }

    public class Item
    {
        public string id { get; set; }
        public string title { get; set; }
        public string site_id { get; set; }
        public string condition { get; set; }
        public decimal price { get; set; }
        public string permalink { get; set; }
    }

    public class ItemSearchResult
    {
        public ItemSearchResult() {
            results = new Item[0];
        }

        public Item[] results { get; set; }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
