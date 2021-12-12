// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\Search.razor"
       
    public string AutoVal;
    Dictionary<string, string> dictSearch = new Dictionary<string, string>();
    List<TickName> coinList = new List<TickName>();


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


    string CurrencySearch = "";
    JObject jsonObj = new JObject();
    Dictionary<string, string> DictObj = new Dictionary<string, string>();

    public List<Currencycon> ListCurrency { get; set; }


    private async void TheButtonClicked()
    {
        foreach (var item in dictSearch)
        {
            if (item.Value == AutoVal)
            {
                CurrencySearch = item.Key;
            }
        }

        try
        {
            HttpClient clnt = new HttpClient();
            String jsonString = await clnt.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/" + CurrencySearch + ".json");
            JObject jsonObj = JObject.Parse(jsonString);
            jsonObj.Remove("date");

            DictObj = jsonObj[CurrencySearch].ToObject<Dictionary<string, string>>();

            Change(DictObj);

        }
        catch (Exception)
        {


        }
    }

    public void Change(Dictionary<string, string> dictObj)
    {
        List<Currencycon> tempList = new List<Currencycon>();
        foreach (var item in dictObj)
        {
            Currencycon CurCoin = new Currencycon();

            CurCoin.CoinName = item.Key;
            CurCoin.CoinAmount = item.Value;

            tempList.Add(CurCoin);
        }
        this.ListCurrency = tempList;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591