using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Core.Authorization;
namespace Prestige.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AuthManager _authManager = new AuthManager();
            string result = _authManager.GetInfo();
            Assert.AreEqual("Hello World", result);
        }
    }
}
