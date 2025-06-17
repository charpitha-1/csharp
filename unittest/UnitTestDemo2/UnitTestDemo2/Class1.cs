
namespace UnitTestDemo2lib
{
    public class DemoTest
    {
        public bool DownloadContent(INotifier notifier)
        {
            bool R = notifier.SendNotification();
            return R;   
        }

        
    }
}
