#pragma checksum "E:\Workspace\Asp.Net\lava\Lava.PlayGround\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5cd24e3808776ee1ee42685d4dc245ee33bb176"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Lava.PlayGround.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Lava.PlayGround;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\_Imports.razor"
using Lava.PlayGround.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\Pages\Index.razor"
using Lava.PlayGround.Data;

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
#line 40 "E:\Workspace\Asp.Net\lava\Lava.PlayGround\Pages\Index.razor"
      
    private IEnumerable<Person> People;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        People = new Person[]
        {
          new Person { Salutation = "Mr", GivenName = "Bob", FamilyName = "Geldof" },
          new Person { Salutation = "Mrs", GivenName = "Angela", FamilyName = "Rippon" },
          new Person { Salutation = "Mr", GivenName = "Freddie", FamilyName = "Mercury" }
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
