using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace HotelsWebFormsEmpty
{
	public class BundleConfig
	{
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/Site").Include("~/Scripts/Site.js"));

            bundles.Add(new StyleBundle("~/bundles/SiteCs").Include("~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/bundles/ManageFreeBookings").Include("~/Content/ManageFreeBookings.css"));

            BundleTable.EnableOptimizations = true;



            string str = "";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery.ui.combined", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-ui-" + str + ".min.js",
                DebugPath = "~/Scripts/jquery-ui-" + str + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/" + str + "/jquery-ui.min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jquery.ui/" + str + "/jquery-ui.js",
                CdnSupportsSecureConnection = true
            });



            string st = "3.3.1";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + st + ".min.js",
                DebugPath = "~/Scripts/jquery-" + st + ".js",
                CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + st + ".min.js",
                CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-" + st + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });


            string s = "1.12.4";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery1", new ScriptResourceDefinition
            {
                Path = "~/Scripts/jquery-" + s + ".min.js",
                DebugPath = "~/Scripts/jquery-" + s + ".js",
                CdnPath = "https://code.jquery.com/jquery-" + st + ".min.js",
                CdnDebugPath = "https://code.jquery.com/jquery-" + st + ".js",
                CdnSupportsSecureConnection = true,
                LoadSuccessExpression = "window.jQuery"
            });
        }
    }
}