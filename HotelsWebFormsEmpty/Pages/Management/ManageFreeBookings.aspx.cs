using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Optimization;

namespace HotelsWebFormsEmpty.Pages.Management
{
    public partial class ManageFreeBookings : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //  ClientScript.RegisterStartupScript(GetType(),"Mine", ResolveUrl("~/Scripts/Mine.js"));
            if (Page.IsPostBack)
            {
                var requestTarget = this.Request["__EVENTTARGET"];
                var requestArgs = this.Request["__EVENTARGUMENT"];

                if (requestTarget == "adduser")
                {
                    // do you own validation etc
                    return;
                }
            }
        }
    }
}