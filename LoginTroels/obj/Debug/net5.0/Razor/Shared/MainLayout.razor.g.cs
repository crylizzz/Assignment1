#pragma checksum "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd9372232f67f89cc9881a658554a15991298030"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginTroels.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "b-1rbs310eu8");
            __builder.OpenComponent<LoginTroels.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddAttribute(7, "b-1rbs310eu8");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddAttribute(10, "b-1rbs310eu8");
            __builder.AddContent(11, 
#nullable restore
#line 11 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\horse\RiderProjects\LoginTroels\LoginTroels\Shared\MainLayout.razor"
       

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
            // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
