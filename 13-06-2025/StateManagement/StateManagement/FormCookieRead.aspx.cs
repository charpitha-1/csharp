﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class FormCookieRead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LReadCookie.Text=Request.Cookies["choco"].Value;
        }
    }
}