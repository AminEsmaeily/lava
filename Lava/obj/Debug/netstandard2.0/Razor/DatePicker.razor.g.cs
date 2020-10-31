#pragma checksum "E:\Workspace\Asp.Net\lava\Lava\DatePicker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1c3c92b72f7573a2abdd00cb850554e536db1b"
// <auto-generated/>
#pragma warning disable 1591
namespace Lava
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\Workspace\Asp.Net\lava\Lava\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class DatePicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "date-picker border");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "id", 
#line 3 "E:\Workspace\Asp.Net\lava\Lava\DatePicker.razor"
                 dateInputId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "popup-btn");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 4 "E:\Workspace\Asp.Net\lava\Lava\DatePicker.razor"
                                     PopupClicked

#line default
#line hidden
            ));
            __builder.AddMarkupContent(9, "\r\n        <i class=\"fas fa-calendar-alt\"></i>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "E:\Workspace\Asp.Net\lava\Lava\DatePicker.razor"
        
    private string dateInputId = $"dateInput-{new Random().Next(0, int.MaxValue)}";

    private async void PopupClicked(MouseEventArgs e)
    {
        await Focus(dateInputId);
    }

    public async Task Focus(string elementId)
    {
        await js.InvokeAsync<string>("jsfunction.focusElement", new object[] { elementId });
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
