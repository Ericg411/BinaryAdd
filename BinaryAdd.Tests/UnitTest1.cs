namespace BinaryAdd.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        string a = "11";
        string b = "1";
        string result = _test.AddBinary(a, b);
        Assert.AreEqual("100", result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string a = "1010";
        string b = "1011";
        string result = _test.AddBinary(a, b);
        Assert.AreEqual("10101", result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        string a = "101110";
        string b = "10000011";
        string result = _test.AddBinary(a, b);
        Assert.AreEqual("10110001", result);
    } 
    
    [TestMethod]
    public void TestMethod4()
    {
        string a = "11000000001100";
        string b = "101";
        string result = _test.AddBinary(a, b);
        Assert.AreEqual("11000000010001", result);
    }
}