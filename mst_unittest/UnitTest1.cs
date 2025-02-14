namespace mst_unittest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Execute()
    {
        var val = true;
        Assert.AreEqual(true, val);
    }
}