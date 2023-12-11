using NUnit.Framework;
public class TargetTestCode
{
    // A Test behaves as an ordinary method
    [Test]
    public void Target_false_false()
    {
        TargetCode targetCode = new TargetCode();
        targetCode.TestFunc(false, false);
    }
    [Test]
    public void Target_false_true()
    {
        TargetCode targetCode = new TargetCode();
        targetCode.TestFunc(false, true);
    }
    [Test]
    public void Target_true_false()
    {
        TargetCode targetCode = new TargetCode();
        targetCode.TestFunc(true, false);
    }
}