#pragma checksum "C:\Users\marka\AppData\Roaming\Microsoft\Windows\Network Shortcuts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9571aed4fe22ffc60cd4d90824dc37d732468c3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Index), @"mvc.1.0.view", @"/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9571aed4fe22ffc60cd4d90824dc37d732468c3b", @"/Index.cshtml")]
    #nullable restore
    public class Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SavingFileRazorFrontend.Models.FileSearchModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4 col-md-offset-4"">
            <div class=""LoginStyle"">
                <div class=""panel-body"">
                    <form asp-action=""Index"">
                        <fieldset>
                            <div class=""form-group"">
                                <input class=""form-control"" placeholder=""yourmail@example.com"" asp-for=""Email"" name=""email"" type=""text"">
                            </div>
                            <div class=""form-group"">
                                <input class=""form-control"" placeholder=""search file name"" asp-for=""FileName"" name=""search"" type=""text"">
                            </div>
                            <input class=""btn btn-lg btn-success btn-block"" type=""submit"" value=""search"">
                            <a asp-action=""UploadFile"" class=""btn btn-success"">Uplode file</a>
                        </fieldset>
                    </form>
                    <hr />
          ");
            WriteLiteral("      </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SavingFileRazorFrontend.Models.FileSearchModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
