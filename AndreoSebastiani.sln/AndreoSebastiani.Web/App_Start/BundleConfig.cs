using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AndreoSebastiani.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/commoncss")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/jquery-ui.css")
                );

            bundles.Add(new ScriptBundle("~/bundles/commonjavascript")
                .Include("~/Scripts/jquery-2.1.3.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Scripts/jquery-ui.js")
                );

            BundleTable.EnableOptimizations = true;
        }
    }
}