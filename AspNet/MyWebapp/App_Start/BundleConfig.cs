using System.Web.Optimization;

namespace MyWebapp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/styles")
                   .Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                   .Include("~/Scripts/jquery-{version}.js")
                   .Include("~/Scripts/site.js"));
        }
    }
}
