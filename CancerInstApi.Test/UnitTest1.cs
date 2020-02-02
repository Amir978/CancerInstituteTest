using NUnit.Framework;

namespace CancerInstApi.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPalindromeTest()
        {
            CancerInstApi.BusinessLogic.PalindromeLogic rep = new BusinessLogic.PalindromeLogic();
            var res = rep.IsPalindrome("noon");
            Assert.AreEqual(res, true);
        }
    }
}