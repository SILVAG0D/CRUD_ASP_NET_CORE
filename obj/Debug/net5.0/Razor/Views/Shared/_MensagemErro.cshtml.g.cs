#pragma checksum "C:\Users\gustavo.liesch\Desktop\USANDOVIEWS\Views\Shared\_MensagemErro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e669c173e2c8d43330f2b476ee3e82e6e428a8ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(USANDOVIEWS.Models.Shared.Views_Shared__MensagemErro), @"mvc.1.0.view", @"/Views/Shared/_MensagemErro.cshtml")]
namespace USANDOVIEWS.Models.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e669c173e2c8d43330f2b476ee3e82e6e428a8ef", @"/Views/Shared/_MensagemErro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d297df424680e2c4b068b0c1b4c231753bcdcc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MensagemErro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"alert alert-warning mt-3 alert-dismissible fade-show\" role=\"alert\">\r\n    ");
#nullable restore
#line 3 "C:\Users\gustavo.liesch\Desktop\USANDOVIEWS\Views\Shared\_MensagemErro.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"btn-close\" data-bs-dismmiss=\"alert\"></button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
