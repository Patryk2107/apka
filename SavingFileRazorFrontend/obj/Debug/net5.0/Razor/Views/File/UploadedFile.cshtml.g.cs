#pragma checksum "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a86342ab1a0b3708508005fbca1825ce2011977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_UploadedFile), @"mvc.1.0.view", @"/Views/File/UploadedFile.cshtml")]
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
#line 1 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\_ViewImports.cshtml"
using SavingFileRazorFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\_ViewImports.cshtml"
using SavingFileRazorFrontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a86342ab1a0b3708508005fbca1825ce2011977", @"/Views/File/UploadedFile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405c63069575519d15ba5eed5beb7b38090ca0b8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_File_UploadedFile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SavingFileRazorFrontend.Models.FileModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-dark-blue iq-mt-15 text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "File", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
   ViewData["FileModel"] = "FileModel"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

");
#nullable restore
#line 12 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
 if (Model.Title != "NoAuth")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""table-responsive"">
                <table id=""main-table"" class=""table exotic-table"">
                    <thead>
                    <tr class=""text-center"">
                        <th> ");
#nullable restore
#line 20 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 21 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.StatusFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 22 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.FileType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 23 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 24 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 25 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 26 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 27 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                        <th>");
#nullable restore
#line 28 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    </tr>\n                    </thead>\n                    <tbody class=\"text-center\">\n\n                    <tr>\n                        <td> ");
#nullable restore
#line 34 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 35 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.StatusFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 36 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.FileType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 37 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 38 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 39 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 40 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 41 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.UserSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 42 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                        Write(Html.DisplayFor(modelItem => Model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 43 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
      if (ViewData["Message"] == "Auth")
     {



#line default
#line hidden
#nullable disable
            WriteLiteral("         <td style=\"text-align: right\">\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a86342ab1a0b3708508005fbca1825ce201197713170", async() => {
                WriteLiteral("\n                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a86342ab1a0b3708508005fbca1825ce201197713444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                 <input type=\"submit\" value=\"Usuń\" class=\"btn btn-danger\"/>\n             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a86342ab1a0b3708508005fbca1825ce201197717411", async() => {
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a86342ab1a0b3708508005fbca1825ce201197717704", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    <input type=\"submit\" value=\"Edytuj\" class=\"btn btn-success\" />\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n         </td>\n");
#nullable restore
#line 57 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
     }                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n\n                    </tbody>\n");
            WriteLiteral("                </table>\n            </div>\n        </div>\n        <div>\n            <img");
            BeginWriteAttribute("src", " src=\"", 3160, "\"", 3227, 2);
            WriteAttributeValue("", 3166, "data:image;base64,", 3166, 18, true);
#nullable restore
#line 68 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
WriteAttributeValue("", 3184, System.Convert.ToBase64String(Model.Photo), 3184, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""max-height: 600px; max-width: 400px;""/>
        </div>
        <script>
        $(document).ready(function () {
            $('[data-toggle=""popover""]').popover({ title: ""Payment Modes"", html: true, placement: ""left"" });
        });</script>
    </div>
");
#nullable restore
#line 75 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
 if (Model.Title == "NoAuth")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Picture not found</h1>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a86342ab1a0b3708508005fbca1825ce201197723290", async() => {
                WriteLiteral("Back to search");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 80 "G:\PatrykRepository\patryk\SavingFileRazorFrontend\Views\File\UploadedFile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SavingFileRazorFrontend.Models.FileModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
