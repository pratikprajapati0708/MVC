using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelpers
{
    public static class CustomHelper
    {   //First Method
        public static IHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}>' alt='{1}'</img>", src, alt));
        }
        //Second Method
        public static IHtmlString Img(this HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}>' alt='{1}'</img>", src, alt));
        }
        //Third Method 
        public static IHtmlString ImgTag(this HtmlHelper helper, string src, string alt)
        {
            //return new MvcHtmlString(string.Format("<img src='{0}>' alt='{1}'</img>", src, alt));
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);
            return new MvcHtmlString(tag.ToString());

        }

    }
}