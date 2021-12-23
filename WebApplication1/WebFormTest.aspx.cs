using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string aa;

            Page.RegisterClientScriptBlock("test", "<script>alert('테스트알림');</script>");
        }
    }
}