#pragma checksum "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090d7276c4a0b04a0daba834046c89e41a892872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFaculty), @"mvc.1.0.view", @"/Views/Home/GetFaculty.cshtml")]
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
#nullable restore
#line 1 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090d7276c4a0b04a0daba834046c89e41a892872", @"/Views/Home/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cf9a8a3d709365d985b5294f44413f97a2f2a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/le-frog/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>");
#nullable restore
#line 3 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 5 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
 for (var i = 0; i < Model.Faculty.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        <div class=\"col-sm-3\">\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 211, "", 253, 1);
#nullable restore
#line 9 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 215, String.Concat("myDiv:", i.ToString()), 215, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 297, "\"", 330, 1);
#nullable restore
#line 10 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 303, Model.Faculty[i].imagePath, 303, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 364, "\"", 370, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"caption\">\n                <h3 style=\"font-size:medium\">\n                    ");
#nullable restore
#line 14 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n");
#nullable restore
#line 18 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 821, "", 863, 1);
#nullable restore
#line 29 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 825, String.Concat("myDiv:", i.ToString()), 825, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 907, "\"", 940, 1);
#nullable restore
#line 30 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 913, Model.Faculty[i].imagePath, 913, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 974, "\"", 980, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"caption\">\n                <h3 style=\"font-size:medium\">\n                    ");
#nullable restore
#line 34 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n");
#nullable restore
#line 38 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1431, "", 1473, 1);
#nullable restore
#line 49 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 1435, String.Concat("myDiv:", i.ToString()), 1435, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 1517, "\"", 1550, 1);
#nullable restore
#line 50 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 1523, Model.Faculty[i].imagePath, 1523, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 1584, "\"", 1590, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"caption\">\n                <h3 style=\"font-size:medium\">\n                    ");
#nullable restore
#line 54 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n");
#nullable restore
#line 58 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 2041, "", 2083, 1);
#nullable restore
#line 69 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 2045, String.Concat("myDiv:", i.ToString()), 2045, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 2127, "\"", 2160, 1);
#nullable restore
#line 70 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 2133, Model.Faculty[i].imagePath, 2133, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 2194, "\"", 2200, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"caption\">\n                <h3 style=\"font-size:medium\">\n                    ");
#nullable restore
#line 74 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n        <div>&nbsp;</div>\n        <div>&nbsp;</div>\n    </div>\n");
#nullable restore
#line 81 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"dialog\"></div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090d7276c4a0b04a0daba834046c89e41a89287212284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "090d7276c4a0b04a0daba834046c89e41a89287213308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090d7276c4a0b04a0daba834046c89e41a89287214407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\n    var $j = jQuery.noConflict();\n    var facultyData = ");
#nullable restore
#line 89 "/Users/masonlapine/GitHub/project3-AM/Project3_FinalExam/Views/Home/GetFaculty.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.Faculty)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getName(id) {
        console.log(facultyData);
        let facultyElement = (id).split(':')[1];

        var divContent = ""<div><ul>"";

        divContent += ""<li><font color='#18ADEA'><b><u>Username:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].username + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Title:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].title + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].email + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Phone Number:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].phone + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";

        divContent += ""</ul></div>"";

        con");
            WriteLiteral(@"sole.log(divContent);

        let elmnt = document.getElementById(id);
        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: facultyData[facultyElement].name,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt}
        });
        $j(""#dialog"").dialog(""open"")
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
