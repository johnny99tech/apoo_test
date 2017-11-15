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
        /*falta: test validarcfp(), gerarcpf e repetir test UFS*/
        
        //TEST UF
        //test exception
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
        }//repetir para todas as ufs
        
        //TEST VALIDARCPF()
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void validarcpfTest()
        {
            Program program = new Program();
            if(string cpf > 11){
                Program.validarcpf(cpf);
            }
        }
        
        //TEST GERARCPF()
        
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void gerarcpfTest()
        {
            Program program = new Program();
            if(int x > 10){
                Program.gerarcpf(x);
            }
        }
        
    }
}
