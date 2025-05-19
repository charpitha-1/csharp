using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManagerApp
{
    public abstract class MessageNotifier
    {
        protected virtual void Setup()
        {

        }
        public abstract void Notify(string message);
    }
    public class SMsNotifier : MessageNotifier
    {
        protected override void Setup()
        {
            Console.WriteLine("Setting up from smtp");
        }
        public override void Notify(string sms)
        {
            Setup();
            Console.WriteLine($"Sending SMS:{sms}");
        }
      }
        public class EmailNotifier : MessageNotifier
        {
        protected override void Setup()
        {
            Console.WriteLine("Setting up from email");
        }
        public  override void Notify(string msg)
        {
            Setup();
            Console.WriteLine($"Sending EmailSMS:{msg}");
        }
    }
}
