// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TournamentTracker.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using TournamentTracker.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\_Imports.razor"
using TournamentTracker.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\PrizeForm - Копировать.razor"
using TournamentTracker.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\PrizeForm - Копировать.razor"
using TournamentTracker.Client.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PrizeForm")]
    public partial class PrizeForm___Копировать : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Полина\source\repos\TournamentTracker\TournamentTracker.Client\Pages\PrizeForm - Копировать.razor"
       
    private Prize Prize = new Prize();
    private EditContext editContext;


    protected override void OnInitialized()
    {
        editContext = new EditContext(Prize);
    }

    private async Task HandleSubmit()
    {
        var isValid = editContext.Validate();

        if (isValid)
        {
            Prize newPrize = new Prize(
                   Prize.PlaceNumber,
                   Prize.PlaceName,
                   Prize.PrizeAmount,
                   Prize.PrizePercentage);

            prizeService.CreatePrize(newPrize);

        }
        else
        {

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPrizeService prizeService { get; set; }
    }
}
#pragma warning restore 1591
