#pragma checksum "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772a5afaf281fff941cf788289cd70d0ee6f3570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_List), @"mvc.1.0.view", @"/Views/HomePage/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772a5afaf281fff941cf788289cd70d0ee6f3570", @"/Views/HomePage/List.cshtml")]
    public class Views_HomePage_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetCoreFirstApp.Models.Students>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772a5afaf281fff941cf788289cd70d0ee6f35702758", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <title>Students List</title>\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 202, "\"", 212, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772a5afaf281fff941cf788289cd70d0ee6f35704312", async() => {
                WriteLiteral("\r\n        <h3 class =\"text-center\">Students List</h3>\r\n        <hr>\r\n");
#nullable restore
#line 14 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
         foreach (var student in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <center>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            Number: ");
#nullable restore
#line 20 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
                               Write(student.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                            Name: ");
#nullable restore
#line 21 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
                             Write(student.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                            Surname: ");
#nullable restore
#line 22 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
                                Write(student.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                            Classroom: ");
#nullable restore
#line 23 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
                                  Write(student.Classroom);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </center>\r\n");
#nullable restore
#line 28 "C:\Users\Burak\Desktop\NetCoreFirstApp\Views\HomePage\List.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        
        <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
        <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetCoreFirstApp.Models.Students>> Html { get; private set; }
    }
}
#pragma warning restore 1591