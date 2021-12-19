#pragma checksum "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0628a8b64df28d3349cf470cde69d3f000f760aa"
// <auto-generated/>
#pragma warning disable 1591
namespace UASFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using UASFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProgramKu\UASFrontEnd\_Imports.razor"
using UASFrontEnd.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentpage")]
    public partial class StudentPages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List Of Student</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Student Id</th>\r\n            <th>Last Name</th>\r\n            <th>First Name</th>\r\n            <th>Tanggal Masuk</th>\r\n            <th>Action</th>\r\n\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 18 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
         foreach(var stud in Student){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 20 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                     stud.studentID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 21 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                     stud.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 22 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                     stud.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 23 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                     stud.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 24 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                               $"studentdetail/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddContent(22, "Detail");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<a href class=\"btn btn-primary\">Enrol</a>\r\n                ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 26 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                           $"editstudent/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddContent(28, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 27 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
                           $"deletestudent/{stud.studentID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "btn btn-danger");
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\ProgramKu\UASFrontEnd\Pages\StudentPages.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
