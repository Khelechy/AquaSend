#pragma checksum "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "156c4c376154370b5ad35596f27a64d3527cd5fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Requests), @"mvc.1.0.view", @"/Views/Admins/Requests.cshtml")]
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
#line 1 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\_ViewImports.cshtml"
using aquasend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\_ViewImports.cshtml"
using aquasend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156c4c376154370b5ad35596f27a64d3527cd5fb", @"/Views/Admins/Requests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fe0b072f0a6b1902fa7e60551b85b6aa6cc4ea8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admins_Requests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aquasend.Models.Request>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-2 m-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "driverId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control m-1 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
  
    ViewData["Title"] = "Plans";
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "156c4c376154370b5ad35596f27a64d3527cd5fb8005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h2 class=\"text-center heading mb-5\">Requests</h2>\r\n\r\n");
            WriteLiteral("\r\n    <div class=\"table-responsive table-striped table-hover table-sm table-bordered p-0 m-0\">\r\n        <table id=\"tblCustomers\" cellspacing=\"0\" cellpadding=\"5\" width=\"100%\">\r\n            <thead");
            BeginWriteAttribute("class", " class=\"", 1004, "\"", 1012, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <tr>
                    <th class=""col-md-3"">Name</th>
                    <th class=""col-md-3"">Email</th>
                    <th class=""col-md-3"">Phone</th>
                    <th class=""col-md-2"">Request Date</th>
                    <th class=""col-md-2"">Request Time</th>
                    <th class=""col-md-3"">Driver Email</th>
                    <th class=""col-md-2"">Status</th>
                    <th class=""col-md-5"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                  
                    if (Model != null)
                    {
                        if (Model.Count() > 0)
                        {
                            foreach (var request in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"col-md-3\">");
#nullable restore
#line 47 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                                            Write(request.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-3\">");
#nullable restore
#line 48 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-3\">");
#nullable restore
#line 49 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-3\">");
#nullable restore
#line 50 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.RequestDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-2\">");
#nullable restore
#line 51 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.RequestDate.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-3\">");
#nullable restore
#line 52 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.DriverEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-2\">");
#nullable restore
#line 53 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                    Write(request.RequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"col-md-5\">\r\n");
#nullable restore
#line 55 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                          
                                            if (request.RequestStatus == aquasend.Enums.RequestEnum.pending)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"col-md-1\">\r\n                                                <button class=\"btn btn-primary mt-2 m-auto\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2917, "\"", 2951, 3);
            WriteAttributeValue("", 2927, "toggleModal(", 2927, 12, true);
#nullable restore
#line 60 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
WriteAttributeValue("", 2939, request.Id, 2939, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2950, ")", 2950, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#modal\">Approve</button>\r\n                                            </td>\r\n");
            WriteLiteral("                                            <td class=\"col-md-1\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156c4c376154370b5ad35596f27a64d3527cd5fb14824", async() => {
                WriteLiteral("\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156c4c376154370b5ad35596f27a64d3527cd5fb15135", async() => {
                    WriteLiteral("Reject");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                                                                         WriteLiteral(request.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 73 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                        }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                }

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                                        
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p align=\"center\"><b>No Request Found</b></p>\r\n");
#nullable restore
#line 93 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
                            }
                        }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"text-center mt-3\">\r\n        ");
#nullable restore
#line 100 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
   Write(Html.Raw(ViewBag.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div id=""modal"" class=""modal"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-body m-3"">
                <h3 class=""text-center mb-3"">Assign Driver</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156c4c376154370b5ad35596f27a64d3527cd5fb20852", async() => {
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <input class=\"form-control m-2 col-md-5\" name=\"id\" id=\"requestId\" type=\"number\" hidden />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156c4c376154370b5ad35596f27a64d3527cd5fb21303", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156c4c376154370b5ad35596f27a64d3527cd5fb21600", async() => {
                        WriteLiteral("Assign a driver");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            \r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 112 "C:\Users\konyekwere\source\repos\Mine\aquasend\aquasend\Views\Admins\Requests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DriverId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <button class=\"mt-3 btn-sm\" type=\"submit\">Submit</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    function toggleModal(id) {\r\n        document.getElementById(\"requestId\").value = id;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aquasend.Models.Request>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591