#pragma checksum "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2668df96a0aa9b76e8d524f47199be7d55347477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_Index), @"mvc.1.0.view", @"/Views/Class/Index.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\_ViewImports.cshtml"
using FinalAgain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\_ViewImports.cshtml"
using FinalAgain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2668df96a0aa9b76e8d524f47199be7d55347477", @"/Views/Class/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73240406aff77632ff5f9cf117b335a1bbf4fa7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Class_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addTeacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
  
    var data = User.FindFirstValue(ClaimTypes.Role);
    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    var check = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
 if (data == "Admin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2668df96a0aa9b76e8d524f47199be7d553474775461", async() => {
                WriteLiteral("Create  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
 if (data == "Admin" || data == "HeadOfDepartment")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Code</th>
                <th scope=""col"">Credit</th>
                <th scope=""col"">Instructor  Name</th>
                <th scope=""col"">Enrolled Students</th>
");
#nullable restore
#line 23 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 if (data == "HeadOfDepartment")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"col\">Actions</th>\r\n");
#nullable restore
#line 26 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
             if (ViewBag.clas != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 foreach (Class item in ViewBag.clas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                         if (item.TeacherId != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 41 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                           Write(ViewBag.teacherNmae);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Not specified</td>\r\n");
#nullable restore
#line 46 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n");
#nullable restore
#line 48 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                             foreach (StudentClass ST in item.StudentClasses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 50 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                              Write(ST.Student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 51 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                                 if (data == "HeadOfDepartment")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2668df96a0aa9b76e8d524f47199be7d5534747711677", async() => {
                WriteLiteral("Add Instructor ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 65 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
 if (data == "Student")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h3>Unregistered Classes</h3>
    <table class=""table"">

        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Code</th>
                <th scope=""col"">Credit</th>
                <th scope=""col"">Instructor  Name</th>
                <th scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 81 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
             if (ViewBag.clas != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 foreach (Class item in ViewBag.clas)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 86 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 87 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 88 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                         if (item.TeacherId != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 92 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                           Write(ViewBag.teacherNmae);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 93 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"

                            check=true;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Not specified</td>\r\n");
#nullable restore
#line 99 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                         if (check)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2668df96a0aa9b76e8d524f47199be7d5534747718254", async() => {
                WriteLiteral("Join This Class");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                                                                                          WriteLiteral(userId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 105 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                            check= false;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td>\r\n                                <button class=\"btn  btn-warning\" disabled>Wait for Manager to add the Instructer</button>\r\n                            </td>\r\n");
#nullable restore
#line 112 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 116 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            WriteLiteral(@"    <h3>Enrolled</h3>
    <table class=""table"">

        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Code</th>
                <th scope=""col"">Credit</th>
                <th scope=""col"">Instructor  Name</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 133 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
             if (ViewBag.clas != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 foreach (Class item in ViewBag.enrolledClasses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 138 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 139 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 140 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                       Write(item.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 142 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                         if (item.TeacherId != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 144 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                           Write(ViewBag.teacherNmae);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 145 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Not specified</td>\r\n");
#nullable restore
#line 149 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 152 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 156 "C:\Users\Baxtiyar\Desktop\Final-Back-master\FinalAgain\Views\Class\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
