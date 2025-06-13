using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FromViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIdSave_Click(object sender, EventArgs e)
        {
            ViewState.Add("CURTIME", DateTime.Now.ToLongTimeString());
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            LView.Text = ViewState["CURTIME"].ToString();
        }
        protected void  Page_Error(object sender, EventArgs e)
        {
            Server.ClearError();
            Response.Redirect("Error.aspx");
        }
    }
}