using System;
using System.Web.Optimization;

namespace ETicaret
{
    class BundleConfig
    {
        internal static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/MyStyles").Include(
                "~/Temp/vendors/fontawesome/css/all.min.css" ,
                "~/Temp/vendors/themify-icons/themify-icons.css",
                "~/Temp/vendors/nice-select/nice-select.css",
                "~/Temp/vendors/owl-carousel/owl.theme.default.min.css",
                "~/Temp/vendors/owl-carousel/owl.carousel.min.css"//,
                //"~/Temp/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/MyScripts").Include(
                "~/Temp/vendors/jquery/jquery-3.2.1.min.js",
                "~/Temp/vendors/bootstrap/bootstrap.bundle.min.js",
                "~/Temp/vendors/skrollr.min.js",
                "~/Temp/vendors/owl-carousel/owl.carousel.min.js",
                "~/Temp/vendors/nice-select/jquery.nice-select.min.js",
                "~/Temp/vendors/jquery.ajaxchimp.min.js",
                "~/Temp/vendors/mail-script.js",
                "~/Temp/js/main.js"
                ));
            BundleTable.EnableOptimizations = true;
        }
    }
}
