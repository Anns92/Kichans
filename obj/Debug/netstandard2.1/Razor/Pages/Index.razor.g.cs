#pragma checksum "E:\asp\kichans\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924cb7d20b3d12a2c3e96bae881e8edcdecf200f"
// <auto-generated/>
#pragma warning disable 1591
namespace kichans.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<kichans.Shared.Slider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"container\" style=\"margin-top:30px\">\r\n    <div class=\"row justify-content-center mb-4\">\r\n        <h2>Your Needs</h2>\r\n    </div>\r\n    <div class=\"row \">\r\n        <div class=\"col-md-6 col-sm-12  my-3\">\r\n            \r\n            <div class=\"card border-0  booking-card box-shadow-hover\">\r\n                \r\n                <div class=\"view overlay\">\r\n                    <img class=\"card-img-top\" src=\"assets/images/employeetonorway.jpg\" alt=\"Card image cap\">\r\n                </div>\r\n\r\n                \r\n                <div class=\"card-body text-center\">\r\n                    \r\n                    <h4 class=\"card-title font-weight-bold text-theme-color\">\r\n                        FOREIGN EMPLOYEE TO NORWAY\r\n                    </h4>\r\n\r\n                    \r\n                    \r\n                    <div class=\"d-flex  justify-content-end\">\r\n                        <a href=\"/foreign_employee\" class=\"btn bg-theme-color rounded-pill btn-sm text-light p-1 px-2 mx-0 mb-0\">Read more</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n        <div class=\"col-md-6 col-sm-12  my-3\">\r\n            \r\n            <div class=\"card booking-card box-shadow-hover\">\r\n                \r\n                <div class=\"view overlay\">\r\n                    <img class=\"card-img-top\" src=\"assets/images/employeeabroad.jpg\" alt=\"Card image cap\">\r\n                </div>\r\n\r\n                \r\n                <div class=\"card-body text-center\">\r\n                    \r\n                    <h4 class=\" font-weight-bold text-theme-color\">\r\n                        EMPLOYEE GOING ABROAD\r\n                    </h4>\r\n\r\n                    \r\n                    <div class=\"d-flex  justify-content-end\">\r\n                        <a href=\"/employee_abroad\" class=\"btn bg-theme-color  text-light rounded-pill btn-sm  p-1 px-2 mx-o mb-0\">Read more</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"pt-5 mt-3\"></div>\r\n");
            __builder.OpenComponent<kichans.Shared.HowWeWork>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<kichans.Shared.Banner>(5);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
