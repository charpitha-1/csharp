namespace UnitTestDemo1
{
    public class DownloadManager
    {
        public bool DownloadFile()
        {
            return true;
        }
        public long FileCount()
        {
            return 34;
        }
        public long incrementCount(long val)
        {
            return ++val;
        }
        public bool ThrowException()
        {
            throw new Exception();
        }
    }
    public class DataClass
    {
        public static IEnumerable<long> DataProvider()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }
    }
}
