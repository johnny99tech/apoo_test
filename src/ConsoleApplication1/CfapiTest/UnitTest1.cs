using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CpfApi
{
    [TestClass]
    public class ufTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void getufTest1()
        {
            uf ufs = new uf();
            ufs.getuf(0);
        }

        [TestMethod]
        public void getufTest2()
        {
            uf ufs = new uf();
            string UF = ufs.getuf(0);
            Assert.AreEqual("DF, GO, MS, TO", UF);
            Assert.AreNotEqual("PA, AM, AC, AP, RR, RO", UF);
        }
    }
}
