using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Quiron.LojaVirtual.Web.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-1.*"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryVal").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css","~/Content/ErrorStyle.css","~/Content/ErrorStyle.css"));

            BundleTable.EnableOptimizations = false;

        }
    }
}