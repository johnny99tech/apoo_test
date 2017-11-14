using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CpfApi
{
    public class uf
    {
        string[] ufs = {"DF, GO, MS, TO",
                    "PA, AM, AC, AP, RR, RO", 
                    "CE, MA, PI", 
                    "PE, PB, RN, AL", 
                    "BA, SE", 
                    "MG", 
                    "RJ, ES", 
                    "SP", 
                    "PR, SC", 
                    "RS"
        };
        public string getuf(int uf)
        {
            if (uf > 10)
            {
                throw new IndexOutOfRangeException();
                return "";
            }
            else
            {
                return ufs[uf];
            }
        }
    }
}
