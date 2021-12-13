// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ca3.Pages
{
    #line hidden
    using System;
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
#line 12 "C:\Users\Mohamed\Documents\ead\ca3\ca3\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CurrencyChart")]
    public partial class CurrencyChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Mohamed\Documents\ead\ca3\ca3\Pages\CurrencyChart.razor"
       

    public string firstVal;
    public string secondVal;
    string CurrencySearch;
    string CurrencySearch2;
    string daydate;
    DateTime[] last7Days;
    Dictionary<string, string> dictSearch = new Dictionary<string, string>();
    List<TickName> coinList = new List<TickName>();
    List<string> listofDates = new List<string>();
    List<CurrencyLineChart> Last7days = new List<CurrencyLineChart>();


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

        DateTime[] last7Days = Enumerable.Range(1, 7)
        .Select(i => DateTime.Now.Date.AddDays(-i)).ToArray();

        foreach (var day in last7Days)
        {
            daydate = ($"{day:yyyy-MM-dd}");
            listofDates.Add(daydate);
        }


    }


    public async void TheButtonClicked()
    {
        Last7days.Clear();

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

        foreach (var weekday in listofDates)
        {
            HttpClient clnt = new HttpClient();
            String jsonString = await clnt.GetStringAsync("https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/" + weekday + "/currencies/" + CurrencySearch + "/" + CurrencySearch2 + ".json");
            JObject jsonObj = JObject.Parse(jsonString);

            OrganizeData(jsonObj);

        }

        StateHasChanged();

    }



    public void OrganizeData(JObject data)
    {
        List<CurrencyLineChart> tempList = new List<CurrencyLineChart>();

        CurrencyLineChart CurCoin = new CurrencyLineChart();

        CurCoin.Period = Convert.ToDateTime(data["date"]);

        CurCoin.Currency = Convert.ToDouble(data[CurrencySearch2]);

        tempList.Add(CurCoin);


        Last7days.AddRange(tempList);


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
