using System.Web.Optimization;
using System.Web.Optimization.React;

namespace flux_chatASP4
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/flux-chat/js/bundle.js"
                ));

            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            BundleTable.EnableOptimizations = false;
        }
    }
}