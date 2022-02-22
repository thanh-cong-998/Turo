﻿using System.Web;
using System.Web.Optimization;

namespace OnlineShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jscore").Include(
                        "~/Scripts/jquery-{version}.js"
                        //"~/Assets/Client/js/jquery-3.6.0.min.js",
                        //"~/Assets/Client/js/jquery-ui.js",
                        //"~/Assets/Client/js/bootstrap.min.js",
                        //"~/Assets/Client/js/move-top.js",
                        //"~/Assets/Client/js/easing.js",
                        //"~/Assets/Client/js/startstop-slider.js"
                        ));
            //bundles.Add(new ScriptBundle("~/bundles/controller").Include(
            //            "~/Assets/Client/js/baseController.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //bundles.Add(new StyleBundle("~/bundles/core").Include(
            //          "~/Assets/Client/css/bootstrap.css",
            //          "~/Assets/Client/css/boostrap-social.css",
            //          "~/Assets/Client/css/font-awesome.min.css",
            //          "~/Assets/Client/css/bootstrap-theme.css",
            //          "~/Assets/Client/css/jquery-ui.css",
            //          "~/Assets/Client/css/style.css",
            //          "~/Assets/Client/css/slider.css"
            //    ));

            //BundleTable.EnableOptimizations = true;
        }
    }
}
