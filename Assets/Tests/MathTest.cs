using NUnit.Framework; //測試框架
using UnityEngine;

public class MathTest
{
    [Test]
    public void AddTwoNumbers_ReturnsCorrectResult()
    {
        int a = 3;
        int b = 5;
        int result = Add(a, b);
        Assert.AreEqual(8, result);
    }

    int Add(int x, int y)
    {
        return x + y;
    }
}
