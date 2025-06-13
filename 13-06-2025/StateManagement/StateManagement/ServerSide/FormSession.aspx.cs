using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement.ServerSide
{
    public partial class FormSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSession_Click(object sender, EventArgs e)
        {
            Session.Add("MySession", DateTime.Now.ToLongTimeString());
            Response.Redirect("FormReadSession.aspx");
        }
    }
}