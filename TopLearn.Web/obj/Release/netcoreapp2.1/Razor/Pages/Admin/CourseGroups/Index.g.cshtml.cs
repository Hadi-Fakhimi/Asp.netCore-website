#pragma checksum "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45dde1f3caf99f6bf514ce5704880e6ad2396ec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_CourseGroups_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/CourseGroups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/CourseGroups/Index.cshtml", typeof(AspNetCore.Pages_Admin_CourseGroups_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45dde1f3caf99f6bf514ce5704880e6ad2396ec6", @"/Pages/Admin/CourseGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_CourseGroups_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 675, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست گروه  ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست گروه های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            EndContext();
            BeginContext(780, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d50f1ca0dc439787c9d1560948a778", async() => {
                BeginContext(842, 16, true);
                WriteLiteral("افزودن گروه جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(862, 569, true);
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>عنوان گروه</th>
                                    <th>زیر گروه ها</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 38 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                 foreach (var group in Model.CourseGroups.Where(g=>g.ParentId==null))
                                {

#line default
#line hidden
            BeginContext(1569, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1656, 16, false);
#line 41 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                       Write(group.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1672, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 43 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                             if (group.CourseGroups.Any())
                                            {

#line default
#line hidden
            BeginContext(1848, 54, true);
            WriteLiteral("                                                <ul>\r\n");
            EndContext();
#line 46 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                     foreach (var sub in group.CourseGroups)
                                                    {

#line default
#line hidden
            BeginContext(2051, 122, true);
            WriteLiteral("                                                        <li>\r\n                                                            ");
            EndContext();
            BeginContext(2174, 14, false);
#line 49 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                       Write(sub.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2188, 8, true);
            WriteLiteral(" -    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2196, "\"", 2245, 2);
            WriteAttributeValue("", 2203, "/Admin/CourseGroups/EditGroup/", 2203, 30, true);
#line 49 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2233, sub.GroupId, 2233, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2246, 247, true);
            WriteLiteral(" class=\"btn btn-outline btn-warning btn-xs\">\r\n                                                                ویرایش\r\n                                                            </a>\r\n                                                        </li>\r\n");
            EndContext();
#line 53 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(2548, 55, true);
            WriteLiteral("                                                </ul>\r\n");
            EndContext();
#line 55 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2650, 139, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2789, "\"", 2842, 2);
            WriteAttributeValue("", 2796, "/Admin/CourseGroups/CreateGroup/", 2796, 32, true);
#line 58 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2828, group.GroupId, 2828, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2843, 185, true);
            WriteLiteral(" class=\"btn btn-info btn-sm\">\r\n                                                زیر گروه\r\n                                            </a>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3028, "\"", 3079, 2);
            WriteAttributeValue("", 3035, "/Admin/CourseGroups/EditGroup/", 3035, 30, true);
#line 61 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 3065, group.GroupId, 3065, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3080, 230, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                                ویرایش\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 66 "F:\Asp.Net Core 2 Advanded\42_Asp.NetCore2Advance\TopLearn\TopLearn.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3345, 269, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Web.Pages.Admin.CourseGroups.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.CourseGroups.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.CourseGroups.IndexModel>)PageContext?.ViewData;
        public TopLearn.Web.Pages.Admin.CourseGroups.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
