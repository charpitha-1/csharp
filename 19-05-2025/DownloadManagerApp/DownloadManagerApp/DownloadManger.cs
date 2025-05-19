using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerApp
{
    //public delegate void Sendnotification(string msg);
    public class DownloadManger
    {

        string _urlpath;
        public DownloadManger(string urlpath)
        {
            _urlpath = urlpath;
        }
        public void DownloadContent(Sendnotification notifier )
        {
            bool Status = true;
            Console.WriteLine($"File Downloaded path: {_urlpath}");
            Console.WriteLine("Successfully downloaded");
            notifier("success");
        }
       
    }
}
