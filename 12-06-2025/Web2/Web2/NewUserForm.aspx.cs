﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class NewUserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Confirmation.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
        protected void Page_PreInit()
        {
           // Theme = "Skin2";
        }
    }
}