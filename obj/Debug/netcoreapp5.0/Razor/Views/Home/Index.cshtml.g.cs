#pragma checksum "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62678da91e510faf9b1f6bee28ae74df1c42c0e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\_ViewImports.cshtml"
using book.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62678da91e510faf9b1f6bee28ae74df1c42c0e8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dd35a86a2649ee4fe97baa6f28501d756792cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Category>, List<Publisher>, List<Book>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Category> categories = Model.Item1;
    List<Publisher> publishers = Model.Item2;
    List<Book> books = Model.Item3;
    Category category1 = ViewBag.Category;
    SubCategory subCategory1 = ViewBag.SubCategory;
    int page = ViewBag.Page;
    int maxPage = ViewBag.MaxPage;
    string pageUrl = "/?";
    if (subCategory1 != null) pageUrl = "/?subCategory=" + subCategory1.Id + "&";
    else if (category1 != null) pageUrl = "/?category=" + category1.Id + "&";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""grid"">
    <div class=""grid__row app__content"">
        <div class=""grid__column-2"">
            <nav class=""category"">
                <h3 class=""category__heading"">
                    <i class=""fas fa-list category__heading-icon""></i>
                    Danh mục
                </h3>
                <ul class=""category__list"">
                    <li class=""category__items category__items-active"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1041, "\"", 1048, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"category__items-link\">\r\n                            <i class=\"fas fa-chevron-down\"></i>\r\n                            Sản phẩm</a>\r\n                    </li>\r\n");
#nullable restore
#line 29 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                     foreach (var category in categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category__items\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1381, "\"", 1411, 2);
            WriteAttributeValue("", 1388, "/?category=", 1388, 11, true);
#nullable restore
#line 32 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 1399, category.Id, 1399, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category__items-link\"> ");
#nullable restore
#line 32 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                                                       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <i class=\"fas fa-chevron-right category__items-linkicon\"></i>\r\n                            </a>\r\n                            <ul class=\"cateitems__list\">\r\n");
#nullable restore
#line 36 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                 foreach (var subcategory in category.SubCategories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"cateitems__items\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1876, "\"", 1912, 2);
            WriteAttributeValue("", 1883, "/?subCategory=", 1883, 14, true);
#nullable restore
#line 39 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 1897, subcategory.Id, 1897, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                    class=\"cateitems__items--link\">");
#nullable restore
#line 40 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                              Write(subcategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 42 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 45 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <ul class=\"category__list\">\r\n                    <li class=\"category__items category__items-active\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2339, "\"", 2346, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-link"">
                            <!-- <i class=""fas fa-chevron-down""></i> -->
                            Giá
                        </a>
                    </li>
                    <li class=""category__items"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 2619, "\"", 2626, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-checkbox"">
                            <input type=""checkbox"" class=""category__check"">
                            0-150,000đ
                        </a>
                    </li>
                    <li class=""category__items"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 2913, "\"", 2920, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-checkbox"">
                            <input type=""checkbox"" class=""category__check"">
                            0-150,000đ
                        </a>
                    </li>
                    <li class=""category__items"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 3207, "\"", 3214, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-checkbox"">
                            <input type=""checkbox"" class=""category__check"">
                            0-150,000đ
                        </a>
                    </li>

                </ul>
                <ul class=""category__list"">
                    <li class=""category__items category__items-active"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 3594, "\"", 3601, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-link"">
                            <!-- <i class=""fas fa-chevron-down""></i> -->
                            Hình thức
                        </a>
                    </li>
                    <li class=""category__items"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 3880, "\"", 3887, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-checkbox"">
                            <input type=""checkbox"" class=""category__check"">
                            Bìa mềm
                        </a>
                    </li>
                    <li class=""category__items"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 4171, "\"", 4178, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""category__items-checkbox"">
                            <input type=""checkbox"" class=""category__check"">
                            Bìa cứng
                        </a>
                    </li>

                </ul>
                <ul class=""category__list"">
                    <li class=""category__items category__items-active"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 4556, "\"", 4563, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"category__items-link\">\r\n                            <!-- <i class=\"fas fa-chevron-down\"></i> -->\r\n                            Nhà cung cấp\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 102 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                     foreach (var publisher in publishers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"category__items\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4936, "\"", 4943, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"category__items-checkbox\">\r\n                                <input type=\"checkbox\" class=\"category__check\">\r\n                                ");
#nullable restore
#line 107 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                           Write(publisher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 110 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n\r\n\r\n        <div class=\"grid__column-10\">\r\n");
#nullable restore
#line 118 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
             if (category1 == null && subCategory1 == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"slider\">\r\n                    <figure>\r\n\r\n                        <img src=\"https://cdn0.fahasa.com/media/magentothem/banner7/DCVP__920x420.png\" class=\"slider_img\"");
            BeginWriteAttribute("alt", "\r\n                        alt=\"", 5566, "\"", 5597, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"https://cdn0.fahasa.com/media/magentothem/banner7/bs2920x420.png\" class=\"slider_img\"");
            BeginWriteAttribute("alt", "\r\n                        alt=\"", 5719, "\"", 5750, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"https://cdn0.fahasa.com/media/magentothem/banner7/zlpt4-920x420.png\" class=\"slider_img\"");
            BeginWriteAttribute("alt", "\r\n                        alt=\"", 5875, "\"", 5906, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"https://cdn0.fahasa.com/media/magentothem/banner7/Game_Trang-chung-920x420.jpg\"\r\n                        class=\"slider_img\"");
            BeginWriteAttribute("alt", " alt=\"", 6067, "\"", 6073, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img src=\"https://cdn0.fahasa.com/media/magentothem/banner7/DCVP__920x420.png\" class=\"slider_img\"");
            BeginWriteAttribute("alt", "\r\n                        alt=\"", 6198, "\"", 6229, 0);
            EndWriteAttribute();
            WriteLiteral("> -\r\n\r\n                    </figure>\r\n                </div>\r\n");
#nullable restore
#line 136 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container"" style=""background-color: transparent !important; padding-bottom: 0; padding-top: 0;"">
                    <div class=""row"">
                        <a class=""path-item"" href=""/"">Trang chủ</a>
                        <a class=""path-item"">></a>
                        <a class=""path-item""");
            BeginWriteAttribute("href", " href=\"", 6670, "\"", 6701, 2);
            WriteAttributeValue("", 6677, "/?category=", 6677, 11, true);
#nullable restore
#line 143 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 6688, category1.Id, 6688, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                                        Write(category1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 144 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                         if (subCategory1 != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"path-item\">></a>\r\n                            <a class=\"path-item\"");
            BeginWriteAttribute("href", " href=\"", 6907, "\"", 6944, 2);
            WriteAttributeValue("", 6914, "/?subCategory=", 6914, 14, true);
#nullable restore
#line 147 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 6928, subCategory1.Id, 6928, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 147 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                                                  Write(subCategory1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 148 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 151 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""home__fiter"">
                <span class=""home__fiter-heading"">
                    Sắp xếp theo
                </span>
                <button class=""btn btn-home__fiter"">
                    Phổ biến
                </button>
                <button class=""btn btn--primary btn-home__fiter"">
                    Mới nhất
                </button>
                <button class=""btn btn-home__fiter"">
                    Bán chạy
                </button>
                <div class=""home__fiter-pages"">
                    <span class=""home__pages-number"">
                        <span class=""home__pages-current""> 1</span>/14
                    </span>
                    <div class=""home__pages-control"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 7846, "\"", 7853, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"home__pages-button home__pages-button-disable\">\r\n                            <i class=\"fas fa-chevron-left home__button-icon\"></i>\r\n                        </a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 8050, "\"", 8057, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""home__pages-button"">
                            <i class=""fas fa-chevron-right home__button-icon""></i>
                        </a>
                    </div>
                </div>
            </div>
            <div class=""home__product"">
                <div class=""grid__row"">
");
#nullable restore
#line 181 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                     foreach (var book in books)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid__column-2-4\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 8515, "\"", 8538, 2);
            WriteAttributeValue("", 8522, "/detail/", 8522, 8, true);
#nullable restore
#line 184 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 8530, book.Id, 8530, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"home__product-items\">\r\n                                <div class=\"home__product-itemsimg\"");
            BeginWriteAttribute("style", " style=\"", 8637, "\"", 8689, 4);
            WriteAttributeValue("", 8645, "background-image:", 8645, 17, true);
            WriteAttributeValue(" ", 8662, "url(", 8663, 5, true);
#nullable restore
#line 185 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 8667, book.BookMeta.BgUrl, 8667, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8687, ");", 8687, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <h4 class=\"home__product-itemsname\">");
#nullable restore
#line 187 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                               Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div class=\"home__product-itemsprice\">\r\n                                    <span class=\"home__product-itemsoldprice\">");
#nullable restore
#line 189 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                                         Write(book.BookMeta.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</span>\r\n                                    <span class=\"home__product-itemsnewprice\">");
#nullable restore
#line 190 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                                                         Write(book.BookMeta.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VND</span>

                                </div>
                                <div class=""home__product-itemsaction"">
                                    <div class=""home__product-itemslike home__product-itemslike-liked"">
                                        <i class=""fas fa-heart home__product-items-icon-fill""></i>
                                        <i class=""far fa-heart home__product-items-icon-empty""></i>
                                    </div>
                                    <div class=""home__product-itemsvote"">
                                        <i class=""home__product-items-startgold fas fa-star""></i>
                                        <i class=""home__product-items-startgold fas fa-star""></i>
                                        <i class=""home__product-items-startgold fas fa-star""></i>
                                        <i class=""home__product-items-startgold fas fa-star""></i>
                                        <i class=""fas fa-star""></i>
      ");
            WriteLiteral(@"                              </div>
                                </div>
                                <div class=""home__product-itemsfavorite"">
                                    <i class=""fas fa-check""></i>
                                    <span>
                                        Yêu Thích
                                    </span>
                                </div>
                                <div class=""home__product-items-sale"">
                                    <span class=""home__product-items-sale-percent"">
                                        ");
#nullable restore
#line 214 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                                   Write(book.BookMeta.DiscountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%
                                    </span>
                                    <span class=""home__product-items-items-sale-label"">
                                        GIẢM
                                    </span>
                                </div>
                            </a>

                        </div>
");
#nullable restore
#line 223 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <ul class=\"paganition parganition--modifer\">\r\n                <li class=\"paganition__items\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 11303, "\"", 11310, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"paganition__items-link\">\r\n                        <i class=\"fas fa-chevron-left paganition__items-icon\"></i>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 239 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                 for (int i = 1; i <= maxPage; i++)
                {
                    if (@i == page)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"paganition__items paganition__items-active\">\r\n                            <a class=\"paganition__items-link\" style=\"color:white;\">\r\n                                ");
#nullable restore
#line 245 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 248 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"paganition__items\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 12035, "\"", 12059, 3);
#nullable restore
#line 252 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 12042, pageUrl, 12042, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12052, "page=", 12052, 5, true);
#nullable restore
#line 252 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
WriteAttributeValue("", 12057, i, 12057, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"paganition__items-link\">\r\n                                ");
#nullable restore
#line 253 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 256 "D:\STUDY\Nam4Ki2\Hoc may\book\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"paganition__items\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 13256, "\"", 13263, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"paganition__items-link paganition__items-icon\">\r\n                        <i class=\"fas fa-chevron-right\"></i>\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Category>, List<Publisher>, List<Book>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
