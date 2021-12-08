#pragma checksum "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b3bb8e3c62c7c187d5ba12dcfbdfe728a91206"
// <auto-generated/>
#pragma warning disable 1591
namespace ca3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using ca3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using ca3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search for Company</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class");
            __builder.AddAttribute(3, "style", "border-color:black; border-radius:10px");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
                         CurrencySearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrencySearch = __value, CurrencySearch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "class", "btn btn-primary");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
                                                            TheButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, " Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-deck");
#nullable restore
#line 13 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
     try
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Currency</th>\r\n                    <th>amount</th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 24 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
                 foreach (var item in dictObj)
                {
                    Console.WriteLine("{0}: {1}", item.Key, item.Value);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 28 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
                             item.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 29 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
                             item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
       
    }
    catch (Exception)
    {

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
       

    string CurrencySearch = "";
    JObject jsonObj = new JObject();
    Dictionary<string, double> dictObj = new Dictionary<string, double>();

    private async void TheButtonClicked()
    {
        try
        {
            HttpClient clnt = new HttpClient();

            String jsonString = await clnt.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + CurrencySearch + ".json");
            JObject jsonObj = JObject.Parse(jsonString);
            jsonObj.Remove("date");
            //Console.WriteLine(jsonObj[CurrencySearch]);





            dictObj = jsonObj[CurrencySearch].ToObject<Dictionary<string, double>>();

            //Console.WriteLine(dictObj);


            

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
               


        }
        catch (Exception)
        {


        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
