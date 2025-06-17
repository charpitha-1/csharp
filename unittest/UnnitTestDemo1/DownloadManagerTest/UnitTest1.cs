using System.Linq.Expressions;
using NUnit.Framework.Legacy;
using UnitTestDemo1;
namespace DownloadManagerTest
{
    public class Tests
    {
        DownloadManager download;
        //DataClass data;
        [SetUp] //executed before each test case
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            download = new DownloadManager();
            //data=new DataClass();
        }
        public void Setup() //assign the resources
        {
           // download = new DownloadManager();
        }

        [Test] //to odentity the unit testing
        public void Test1()
        {

            //arrange--create the environment
           //DownloadManager downloadManager = new DownloadManager();
            //Act---on that method to test
            bool Actual = download.DownloadFile();
            //Assert---checks the actual and expected matched or not
            //Assert.That(Actual, Is.True); ///is true is expected result
            ClassicAssert.IsTrue(Actual==true);
        }
        [Test]
        public void Test2() {
            
            long ActualValue = download.FileCount();
            Assert.That(ActualValue, Is.EqualTo(34));
        }
        [TestCase(10,11)]
        //[TestCase(20,30)]
        public void Test3(int val,int exp)
        {
            long actual= download.incrementCount(val);
            Assert.That(actual, Is.EqualTo(exp));
        }
        [TestCaseSource(typeof(DataClass),"DataProvider")]
        public void TestSource(long val)
        {
            bool r = val % 5 == 0;
            Assert.That(r, Is.True);
        }
        [Test]
        public void Test4()
        {
            //Assert.Throws<ArgumentException>(() =>
            //{
            //download.ThrowException();
            //});
            Assert.Catch<Exception>(() => {
                download.ThrowException();
                });
        }
        [TearDown]  
       
        public void TearDown() //release the resources
        {

        }
    }
}
