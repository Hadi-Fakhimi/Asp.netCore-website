#pragma checksum "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64269d78baf8fd38b3159f36ceca0d001ea984b2e44ad282725b5eecbcaa83cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActiveEmail), @"mvc.1.0.view", @"/Views/Shared/_ActiveEmail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"64269d78baf8fd38b3159f36ceca0d001ea984b2e44ad282725b5eecbcaa83cf", @"/Views/Shared/_ActiveEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ActiveEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.DataLayer.Entities.User.User>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"direction: rtl; padding: 20px\">\r\n    <h2>");
#nullable restore
#line 4 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز !</h2>\r\n    <p>با تشکر از ثبت نام شما در تاپ لرن ، جهت ادامه کار میبایست حساب کاربری خود را فعال کنید</p>\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 248, "\"", 319, 2);
            WriteAttributeValue("", 255, "http://testintoplearn.in/Account/ActiveAccount/", 255, 47, true);
#nullable restore
#line 7 "C:\Users\mahdi\Desktop\toplearn-website\TopLearn.Web\Views\Shared\_ActiveEmail.cshtml"
WriteAttributeValue("", 302, Model.ActiveCode, 302, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">فعالسازی حساب کاربری</a>\r\n    </p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.DataLayer.Entities.User.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591