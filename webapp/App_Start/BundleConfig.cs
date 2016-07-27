#region Using

using System.Web.Optimization;

#endregion

namespace SmartAdminMvc
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/smartadmin").IncludeDirectory("~/content/css", "*.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularApp")
            .IncludeDirectory("~/Scripts/Controllers", "*.js")
            .Include("~/Scripts/app.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}