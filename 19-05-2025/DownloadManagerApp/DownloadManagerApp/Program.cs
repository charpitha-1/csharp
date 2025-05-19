using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerApp
{
    public delegate void Sendnotification(string msg);
    public class Program
    {
      
        static void Main(string[] args)
        {
            //MessageNotifier msgNotify= new EmailNotifier();
            //MessageNotifier messageNotifier=new SMsNotifier();
            //DownloadManger manager = new DownloadManger("https://ipaddress//endpoint");
            //Sendnotification send = msgNotify.Notify;
            //Sendnotification sendNotification = messageNotifier.Notify;
            ////send += msgNotify.EmailNo;
            //manager.DownloadContent(send);
            //manager.DownloadContent(sendNotification);
            MessageNotifier notifier;
            Console.WriteLine("1.Sms   /2.Email");
            int opt=int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                notifier = new SMsNotifier();
            }
            else
            {
               notifier=new EmailNotifier();
            }

            Sendnotification send = notifier.Notify;
            DownloadManger manager = new DownloadManger("https://ipaddress//endpoint");
            manager.DownloadContent(send);

        }
        
    }
}
