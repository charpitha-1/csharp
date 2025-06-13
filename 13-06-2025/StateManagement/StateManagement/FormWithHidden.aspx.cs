using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FormWithHidden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveHid_Click(object sender, EventArgs e)
        {
            hidtest.Value = DateTime.Now.ToLongTimeString();
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            LHid.Text = hidtest.Value;
        }
    }
}