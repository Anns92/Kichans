#pragma checksum "E:\asp\kichans\Shared\Inquiry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308af6b9c56625216561382fed52960db6943cca"
// <auto-generated/>
#pragma warning disable 1591
namespace kichans.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\asp\kichans\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\asp\kichans\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\asp\kichans\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\asp\kichans\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\asp\kichans\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\asp\kichans\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\asp\kichans\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\asp\kichans\_Imports.razor"
using kichans;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\asp\kichans\_Imports.razor"
using kichans.Shared;

#line default
#line hidden
#nullable disable
    public partial class Inquiry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n<div class=\"mb-2\"></div>\r\n");
            __builder.AddMarkupContent(1, @"<form class=""inquiry my-2 py-1"">

    <div class=""row justify-content-center mb-4"">
        <h3 class=""my-3 text-theme-color font-weight-bold"">Inquiry</h3>
    </div>
    <div class=""row justify-content-center "">
        <div class=""col-xs-10 col-sm-10 col-md-7 col-lg-6 px-4"">
            <div class=""form-group"">
                <input type=""text"" class=""form-control  form-control-sm"" id=""name"" placeholder=""Name"">
            </div>
            <div class=""form-group"">
                <input type=""text"" class=""form-control  form-control-sm"" id=""company_name"" placeholder=""Company name"">
            </div>
            <div class=""form-group"">
                <input type=""text"" class=""form-control  form-control-sm"" id=""phone"" placeholder=""Telephone"">
            </div>
            <div class=""form-group"">
                <input type=""email"" class=""form-control  form-control-sm"" id=""email"" placeholder=""Email"">
            </div>
            <div class=""form-group"">
                <textarea class=""form-control form-control-sm"" id=""message"" rows=""3"" placeholder=""Message""></textarea>
            </div>

            <button type=""submit"" class=""btn btn-block text-white bg-theme-color"">SEND</button>



        </div>

    </div>

    <div class=""mb-2""></div>  <hr>
</form>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
