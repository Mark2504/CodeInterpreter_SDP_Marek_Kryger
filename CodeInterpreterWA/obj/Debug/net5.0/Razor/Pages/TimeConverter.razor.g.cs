#pragma checksum "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6cab49da057da5401ee8ab92dfc241dbc06f21"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeInterpreterWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\_Imports.razor"
using CodeInterpreterWA.Models;

#line default
#line hidden
#nullable disable
    public partial class TimeConverter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TimeConverter</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-4");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label>Hours</label>\r\n             ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "number");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "placeholder", "Hours ....");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
                                                                                       Hours

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Hours = __value, Hours, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n         ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
                                                   ConvertTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<span class=\"oi oi-clock\" aria-hidden=\"true\"></span> Convert\r\n         ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
 if (_seconds != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row blockquote mt-5");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, "In ");
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
                  Hours

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " hours we have ");
            __builder.AddContent(25, 
#nullable restore
#line 18 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
                                       _seconds

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " seconds !");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\dell\source\student_development_program\CodeInterpreter\CodeInterpreterWA\Pages\TimeConverter.razor"
       

    int? _seconds = null;

    public int? Hours { get; set; }

    private void ConvertTime()
    {
        _seconds = Hours * 3600;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
