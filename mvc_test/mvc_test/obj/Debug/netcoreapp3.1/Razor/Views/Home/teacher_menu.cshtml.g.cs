#pragma checksum "D:\GitHub\1\ams\mvc_test\mvc_test\Views\Home\teacher_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a729d42677b42b1e7b46e0cd1073fba78de068f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_teacher_menu), @"mvc.1.0.view", @"/Views/Home/teacher_menu.cshtml")]
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
#line 1 "D:\GitHub\1\ams\mvc_test\mvc_test\Views\_ViewImports.cshtml"
using mvc_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\1\ams\mvc_test\mvc_test\Views\_ViewImports.cshtml"
using mvc_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a729d42677b42b1e7b46e0cd1073fba78de068f", @"/Views/Home/teacher_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6f9a6fd71700b9c586fac4f5e3db051a748975", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_teacher_menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc_test.Models.teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHub\1\ams\mvc_test\mvc_test\Views\Home\teacher_menu.cshtml"
  
    ViewData["Title"] = "teacher_menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>teacher_menu</h1>\r\n\r\n<a href=\"/users/teacher_Index\">填写个人信息</a>\r\n<a href=\"/courses/Create\">创建课程</a>\r\n<a href=\"#\" onclick=\"javascript:alert(\'开启成功\');\">开始签到</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc_test.Models.teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
