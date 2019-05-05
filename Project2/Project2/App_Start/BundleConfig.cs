
using System.Web;
using System.Web.Optimization;

namespace Project2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

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

            bundles.Add(new StyleBundle("~/scripts/home").Include(
                 "~/Content/scripts/API/PlayAPI.js",
                "~/Content/scripts/Home.js"));

            bundles.Add(new StyleBundle("~/scripts/play").Include(
                "~/Content/scripts/API/PlayAPI.js",
                "~/Content/scripts/drawing-app.js",
                "~/Content/scripts/Players.js",
                "~/Content/scripts/Play.js"));

            bundles.Add(new StyleBundle("~/scripts/players").Include(
                "~/Content/scripts/Players.js"));

            bundles.Add(new StyleBundle("~/scripts/setup").Include(
                 "~/Content/scripts/API/PlayAPI.js",
                "~/Content/scripts/Preview.js",
                "~/Content/scripts/Setup.js"));
        }
    }
}
