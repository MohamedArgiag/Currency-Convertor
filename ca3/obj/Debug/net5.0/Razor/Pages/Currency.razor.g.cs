#pragma checksum "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085684366a3a9392bcb3fcaa37d8b6a0b751e3d5"
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
#line 11 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Currency : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"./css/StyleSheet.css\" rel=\"stylesheet\">\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"text-center mt-5\">Currency Conversion</h3>\r\n");
            __builder.AddMarkupContent(2, "<p class=\"text-center\">Please type in the curriences and the amount you wish to be converted.</p>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mb-5 w-25");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfAutoComplete<string, TickName>>(7);
            __builder.AddAttribute(8, "Placeholder", "e.g. Euro");
            __builder.AddAttribute(9, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TickName>>(
#nullable restore
#line 13 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                                                                                                                      coinList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 13 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                                                                                               firstVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => firstVal = __value, firstVal))));
            __builder.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => firstVal));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteFieldSettings>(14);
                __builder2.AddAttribute(15, "Value", "CurName");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "w-25");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfAutoComplete<string, TickName>>(19);
            __builder.AddAttribute(20, "Placeholder", "e.g. Euro");
            __builder.AddAttribute(21, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TickName>>(
#nullable restore
#line 20 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                                                                                                                       coinList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 20 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                                                                                               secondVal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => secondVal = __value, secondVal))));
            __builder.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => secondVal));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteFieldSettings>(26);
                __builder2.AddAttribute(27, "Value", "CurName");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "mt-5");
            __builder.AddMarkupContent(31, "<div><label>Input amount</label></div>\r\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                             tempResult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tempResult = __value, tempResult));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mt-5");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(38);
            __builder.AddAttribute(39, "CssClass", "e-custom");
            __builder.AddAttribute(40, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
                                               TheButtonClicked

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(42, "Enter");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "text-center mt-5");
            __builder.OpenElement(46, "h2");
            __builder.AddContent(47, 
#nullable restore
#line 39 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
             result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Currency.razor"
       

    public string firstVal;
    public string secondVal;
    Dictionary<string, string> dictSearch = new Dictionary<string, string>();
    List<TickName> coinList = new List<TickName>();

    string CurrencySearch;
    string CurrencySearch2;
    double result;
    double tempResult;
    Dictionary<string, string> dictObj = new Dictionary<string, string>();


    protected async override void OnInitialized()
    {
        HttpClient clnt = new HttpClient();
        String searchJsonString = await clnt.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies.json");
        JObject jsonObj = JObject.Parse(searchJsonString);

        dictSearch = jsonObj.ToObject<Dictionary<string, string>>();

        foreach (var item in dictSearch)
        {
            TickName CurCoin = new TickName();

            CurCoin.Tikr = item.Key;
            CurCoin.CurName = item.Value;

            coinList.Add(CurCoin);
        }
    }


    private async void TheButtonClicked()
    {
        try
        {
            foreach (var item in dictSearch)
            {
                if (item.Value == firstVal)
                {
                    CurrencySearch = item.Key;
                }
                else if (item.Value == secondVal)
                {
                    CurrencySearch2 = item.Key;
                }
            }


            HttpClient clnt = new HttpClient();
            String jsonString = await clnt.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + CurrencySearch + "/" + CurrencySearch2 + ".json");
            JObject jsonObj = JObject.Parse(jsonString);
            dictObj = jsonObj.ToObject<Dictionary<string, string>>();

            double r1 = Convert.ToDouble(dictObj[CurrencySearch2]);

            result = Math.Round(tempResult * r1,4);
            StateHasChanged();
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
