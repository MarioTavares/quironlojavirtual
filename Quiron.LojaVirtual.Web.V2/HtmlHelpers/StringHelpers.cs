using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class StringHelpers
    {


        public static string ToSeoUrl(this string url)
        {

            string encodedUrl = (url ?? "").ToLower();

            encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");

            encodedUrl = encodedUrl.Replace("'", "");

            encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9]", "-");

            // remove duplicates
            encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");

            // trim leading & trailing characters
            encodedUrl = encodedUrl.Trim('-');

            return encodedUrl;




        }
    }
}