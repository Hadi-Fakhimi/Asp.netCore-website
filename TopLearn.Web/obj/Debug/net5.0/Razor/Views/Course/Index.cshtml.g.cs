#pragma checksum "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
using TopLearn.DataLayer.Entities.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel>,int>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">تاپ لرن</a></li>
            <li class=""breadcrumb-item active""><a href=""#"">دوره ها</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> برنامه نویسی وب </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e6059", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 670, "\"", 704, 1);
#nullable restore
#line 19 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 678, ViewBag.pageId.ToString(), 678, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
        <section class=""term-categories"">

            <div class=""top-bar"">

                <header>
                    <h1> دوره های <span> برنامه نویسی وب </span> </h1> <span> 123 دوره </span>
                </header>

                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
                        <div class=""input"">
                            <input type=""text"" name=""filter"" placeholder=""موضوع مورد نظر ..."">
                            <button><i class=""zmdi zmdi-search""></i></button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""getType"" value=""all""");
                BeginWriteAttribute("checked", " checked=\"", 1553, "\"", 1563, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                            <label for=""available-filter-1""> همه </label>
                            <input id=""available-filter-2"" name=""getType"" value=""price"" type=""radio"">
                            <label for=""available-filter-2""> خریدنی </label>
                            <input id=""available-filter-3"" name=""getType"" value=""free"" type=""radio"">
                            <label for=""available-filter-3""> رایگان </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderByType"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e8577", async() => {
                    WriteLiteral(" تاریخ انتشار ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e9864", async() => {
                    WriteLiteral(" تاریخ بروز رسانی ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">

                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> فیلتر بر اساس قیمت </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2969, "\"", 2977, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startPrice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3062, "\"", 3070, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""max-price"">تا <span id=""max-text"">500000</span> تومان</div>
                            <div class=""min-price"">از <span id=""min-text"">20000</span> تومان</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> دسته بندی موضوعات </h3>
                        </header>
                        <div class=""inner"">
");
#nullable restore
#line 81 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                              
                                List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
                                List<int> selected = ViewBag.selectedGroups as List<int>;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <ul>\r\n");
#nullable restore
#line 86 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                foreach (var group in groups.Where(g=>g.ParentId==null))
                               {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                   <li>\r\n                                       <input onchange=\"changeGroup()\" type=\"checkbox\" ");
#nullable restore
#line 89 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                   Write((selected.Any(s=>s==group.GroupId)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"selectedGroups\" value=\"");
#nullable restore
#line 89 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                                                                                   Write(group.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                       <label for=\"cat-1\"> ");
#nullable restore
#line 90 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                      Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 91 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                    if (groups.Any(g => g.ParentId == group.GroupId))
                                   {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       <ul>\r\n");
#nullable restore
#line 94 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                            foreach (var sub in groups.Where(g=>g.ParentId==group.GroupId))
                                           {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                               <li>\r\n                                                   <input onchange=\"changeGroup()\" ");
#nullable restore
#line 97 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                               Write((selected.Any(s=>s==sub.GroupId)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 97 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                                                                                             Write(sub.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                                   <label for=\"cat-1\"> ");
#nullable restore
#line 98 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                  Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                               </li>\r\n");
#nullable restore
#line 100 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                       </ul>\r\n");
#nullable restore
#line 102 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                       </li>\r\n");
#nullable restore
#line 105 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                               }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>

                </aside>

                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">

                    <section class=""terms-items"">
                        <div class=""row"">
");
#nullable restore
#line 116 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                             foreach (var item in Model.Item1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9379fef3ff2d9f4573e9a27ab50264644717116fdb2986618aff196200d4ef2e18413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 118 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n\r\n");
#nullable restore
#line 123 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                         if (Model.Item2 > 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <nav aria-label=\"Page navigation\">\r\n                                <ul class=\"pagination justify-content-center\">\r\n                           \r\n");
#nullable restore
#line 128 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                             for(int i=1;i<= (int)Model.Item2; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6458, "\"", 6482, 3);
                WriteAttributeValue("", 6468, "changePage(", 6468, 11, true);
#nullable restore
#line 130 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 6479, i, 6479, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6481, ")", 6481, 1, true);
                EndWriteAttribute();
                WriteLiteral(" href=\"#\">");
#nullable restore
#line 130 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 131 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
  
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </nav>\r\n");
#nullable restore
#line 135 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Course\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </section>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/css/noUiSlider/nouislider.min.js""></script>
    <script src=""/js/script.js""></script>
    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider, {
                start: [20000, 100000],
                step: 5000,
                connect: true,
                direction: 'rtl',
                range: {
                    'min': 20000,
                    'max': 100000
                }
            });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    marginMax.innerHTML = xval");
                WriteLiteral(@"ue;
                } else {
                    marginMin.innerHTML = xvalue;
                }
                //console.log(values[handle]);
            });

            slider.noUiSlider.on('change', function (values, handle) {
                var xvalue = Math.round(values[handle]);
                if (handle) {
                    // setGetParameter('max_price', xvalue);
                    $('#max-value').val(xvalue);
                } else {
                    // setGetParameter('min_price', xvalue);
                    $('#min-value').val(xvalue);
                }
            });


            slider.noUiSlider.on('slide', function (values, handle) {

                console.log(values[0]);
                console.log(values[1]);

                var xvalue = Math.round(values[handle]);
                //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
            });

       

            function updateSliderRange(min, max) {
                slider");
                WriteLiteral(@".noUiSlider.updateOptions({
                    range: {
                        'min': min,
                        'max': max
                    }
                });
            }
        });

        function changeGroup() {
            $(""#formFilter"").submit();
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<TopLearn.Core.DTOs.Course.ShowCourseListItemViewModel>,int>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
