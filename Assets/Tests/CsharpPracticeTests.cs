using NUnit.Framework;
using UnityEngine;

namespace Nancy
{
    public class CsharpPracticeTests
    {
        [Test(Description = "兩個數字相加的驗證")]
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 6)]
        [TestCase(4, 4, 8)]
        [TestCase(-4, 6, 2, TestName = "負數加正數")]
        public void Add_Two_Number(int a, int b, int expected)
        {
            // 宣告一個變數
            CsharpPractice csharpPractice = new CsharpPractice();

            // 呼叫加法，取得相加的結果
            int result = csharpPractice.Add(a , b);

            // 驗證結果
            Assert.AreEqual(expected , actual: result);
        }
    }
}

