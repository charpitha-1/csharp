using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FormInstallCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            HttpCookie http = new HttpCookie("Choco");//choco is a key
            http.Value = "Choco is candy";
            Response.Cookies.Add(http);
            Response.Redirect("FormCookieRead.aspx");
        }
    }
}