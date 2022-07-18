namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void should_convert_decimal_to_int()
    {
        decimal valor = 123.45M;
        var cents = valor.ToCents();

        Assert.AreEqual(12345, cents);
    }
}