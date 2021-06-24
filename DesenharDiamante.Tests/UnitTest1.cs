using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DesenharDiamante;

namespace DesenharDiamante.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Diamante diamante;
        public UnitTest1()
        {
            diamante = new Diamante("c");
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Assert.AreEqual(true, diamante.valorFinal);
        }
    }
}
