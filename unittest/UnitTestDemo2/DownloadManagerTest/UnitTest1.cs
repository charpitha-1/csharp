using UnitTestDemo2lib;
namespace DownloadManagerTest;
using Moq;

public class Tests
{
    DemoTest c;
    [OneTimeSetUp]
    public void Onetime()
    {
       c = new DemoTest();
    }
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestDownloadContent ()
    {
        Mock<INotifier> mockobj= new Mock<INotifier>();
        mockobj.Setup(nf => nf.SendNotification()).Returns(true);
        INotifier fakeobj=mockobj.Object;
        bool ActualR=c.DownloadContent(fakeobj);
        mockobj.Verify();
        Assert.That(ActualR, Is.True);
    }
}
