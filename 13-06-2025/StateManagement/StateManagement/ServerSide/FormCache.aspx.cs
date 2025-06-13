using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement.ServerSide
{
    public partial class FormCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCacheSave_Click(object sender, EventArgs e)
        {
           Cache.Add("Key1","red",new CacheDependency("C:\\Users\\thavishala.c\\Desktop\\ASP.NET\\13-06-2025\\StateManagement\\StateManagement\\ServerSide\\Sample.txt"),Cache.NoAbsoluteExpiration,Cache.NoSlidingExpiration,CacheItemPriority.Normal,null);
            //Cache["Key1"] = "Red";

        }

        protected void btnCacheRead_Click(object sender, EventArgs e)
        {
            if(Cache["Key1"] != null)
            {
                LCache.Text = Cache["Key1"].ToString();
            }
            else
            {
                LCache.Text = "No data in Cache";
            }
        }

        protected void btnCacheRemove_Click(object sender, EventArgs e)
        {
            Cache.Remove("Key1");
        }
    }
}