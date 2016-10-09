using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebAppActor.DataLayer.BusinessLayer;

namespace WebAppActor.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            TagBuilder first = new TagBuilder("a");
            first.MergeAttribute("href", pageUrl(1));
            first.InnerHtml = "<img src='/Content/image/button-first.gif' />";

            TagBuilder prev = new TagBuilder("a");
            if (pagingInfo.CurrentPage == 1)
            {
                prev.MergeAttribute("href", "#");
            }
            else
            {
                prev.MergeAttribute("href", pageUrl(pagingInfo.CurrentPage - 1));
            }
            prev.MergeAttribute("class", "paging-margin");
            prev.InnerHtml = "<img src='/Content/image/button-prev.gif' style='padding-left:3px; ' />";


            TagBuilder next = new TagBuilder("a");
            if (pagingInfo.CurrentPage == pagingInfo.TotalPages)
            {
                prev.MergeAttribute("href", "#");
            }
            else
            {
                next.MergeAttribute("href", pageUrl(pagingInfo.CurrentPage + 1));
            }

            next.InnerHtml = "<img src='/Content/image/button-next.gif' style='padding-left:3px; '/>";




            TagBuilder last = new TagBuilder("a");
            last.MergeAttribute("href", pageUrl(pagingInfo.TotalPages));

            last.InnerHtml = "<img src='/Content/image/button-last.gif' style='padding-left:3px; ' />";


            result.Append(first.ToString());
            result.Append(prev.ToString());
            result.Append(next.ToString());
            result.Append(last.ToString());
            return MvcHtmlString.Create(result.ToString());
        }
    }
}