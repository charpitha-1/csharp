﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FormSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTrans_Click(object sender, EventArgs e)
        {
            Response.Redirect($"FormDestination.aspx?MyVal=1&Myval=2");
        }
    }
}