#pragma checksum "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e193ac7f32901a82db5591dfc2d96303b99980c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UltimateBook), @"mvc.1.0.view", @"/Views/Home/UltimateBook.cshtml")]
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
#line 2 "D:\Masters\DIS\Review.me\Review_me\Views\_ViewImports.cshtml"
using Review_me;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Masters\DIS\Review.me\Review_me\Views\_ViewImports.cshtml"
using Review_me.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e193ac7f32901a82db5591dfc2d96303b99980c0", @"/Views/Home/UltimateBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ffaecef6524ab4510bd221da719e01c472d68c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UltimateBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<script src=""https://code.jquery.com/jquery-1.10.2.min.js""></script>
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css"" rel=""stylesheet"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.bundle.min.js""></script>
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round|Open+Sans"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
<script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>

<link href=""ht");
            WriteLiteral("tps://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e193ac7f32901a82db5591dfc2d96303b99980c04950", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"hero-bg\">\r\n    <div class=\"container\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h3 class=\"card-title\"><b>");
#nullable restore
#line 20 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                     Write(ViewBag.book.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n                <h6 class=\"card-subtitle\">by ");
#nullable restore
#line 21 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                        Write(ViewBag.book.author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5 col-md-5 col-sm-6\">\r\n                        <div class=\"white-box text-center\">\r\n                            <img");
            BeginWriteAttribute("src", " src=", 1618, "", 1647, 1);
#nullable restore
#line 25 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 1623, ViewBag.book.book_image, 1623, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                 class=""img-responsive"">
                        </div>
                    </div>
                    <div class=""col-lg-7 col-md-7 col-sm-6"">
                        <h3>Description</h3>
                        <p>
                            ");
#nullable restore
#line 32 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                       Write(ViewBag.book.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <h2 class=\"mt-5\">\r\n                            $");
#nullable restore
#line 35 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                        Write(ViewBag.book.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small class=\"text-success\">(");
#nullable restore
#line 35 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                                                        Write(ViewBag.book.discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %off)</small>
                        </h2>
                        <!-- <button class=""btn btn-dark btn-rounded mr-1"" data-toggle=""tooltip"" title="""" data-original-title=""Add to cart"">
                            <i class=""fa fa-shopping-cart""></i>
                        </button> -->
                        <a");
            BeginWriteAttribute("href", " href=", 2450, "", 2488, 1);
#nullable restore
#line 40 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 2456, ViewBag.book.amazon_product_url, 2456, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                           target=""_blank"">
                            <input type=""button"" value=""Buy Now"" id=""cta-btn-buy"" />
                        </a>
                        <h3 class=""box-title mt-5"">Publisher</h3>
                        <ul class=""list-unstyled"">
                            <li><i class=""fa fa-check text-success""></i>");
#nullable restore
#line 46 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                                                   Write(ViewBag.book.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <h3 class=\"box-title mt-5\">Rank by genre</h3>\r\n                            <ul class=\"list-unstyled\">\r\n                                <li><i class=\"fa fa-check text-success\"></i>");
#nullable restore
#line 49 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                                                       Write(ViewBag.book.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </ul>\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                        <h3 class=\"box-title mt-5\">Other buying options</h3>\r\n");
#nullable restore
#line 56 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                         foreach (BuyLink b in ViewBag.book.buyLinks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=", 3471, "", 3483, 1);
#nullable restore
#line 58 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 3477, b.url, 3477, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                <input type=\"button\"");
            BeginWriteAttribute("value", " value=", 3554, "", 3568, 1);
#nullable restore
#line 59 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 3561, b.name, 3561, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"cta-btn-buy\" />\r\n                            </a>\r\n");
#nullable restore
#line 61 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""table-title"">
                            <div class=""row"">
                                <div class=""col-sm-8""><h3 class=""box-title mt-5"">Review Sources</h3></div>
                                <div class=""col-sm-4"">
                                    <a");
            BeginWriteAttribute("href", " href=\'", 3951, "\'", 4026, 1);
#nullable restore
#line 66 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 3958, Url.Action("AddReview","Home", new { bookId = ViewBag.book.bookId}), 3958, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <button type=""button"" class=""btn btn-info add-new""><i class=""fa fa-plus""></i> Add New</button>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-product"">
                                <tbody>
");
#nullable restore
#line 75 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                     foreach (ReviewLink r in ViewBag.book.reviewLinks)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td width=\"390\">");
#nullable restore
#line 78 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                                       Write(r.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=", 4840, "", 4852, 1);
#nullable restore
#line 80 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 4846, r.url, 4846, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                                    Click
                                                    Here
                                                </a>
                                            </td>
                                            <td>
                                                <a class=""edit"" title=""Edit"" data-toggle=""tooltip""");
            BeginWriteAttribute("href", " href=\'", 5241, "\'", 5341, 1);
#nullable restore
#line 86 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 5248, Url.Action("UpdateReview","Home", new { bookId = @r.bookId, reviewLinkId = @r.reviewLinkId}), 5248, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <i class=""material-icons"">&#xE254;</i>
                                                </a>
                                                <a class=""delete"" title=""Delete"" data-toggle=""tooltip"" onclick=""return confirm(&#39;Are you sure you want to delete this User?&#39;);""");
            BeginWriteAttribute("href", " href=\'", 5673, "\'", 5753, 1);
#nullable restore
#line 89 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
WriteAttributeValue("", 5680, Url.Action("DeleteReview","Home", new { reviewLinkId = @r.reviewLinkId}), 5680, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <i class=\"material-icons\">&#xE872;</i>\r\n                                                </a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 94 "D:\Masters\DIS\Review.me\Review_me\Views\Home\UltimateBook.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
