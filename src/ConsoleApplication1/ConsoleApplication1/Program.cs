using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        public Program() { }

        uf ufs = new uf();

        Random rand = new Random();

        public List<int> validarcpf(string cpf) // 0 = inva 1 = vali
        {
            List<int> retorno = new List<int>();

            string padrao = "\\d{11}";
            //verifica se cpf possui 11 digitos
            if (!System.Text.RegularExpressions.Regex.IsMatch(cpf, padrao))
                retorno.Add(0);
            else
            {
                //verifica se o CPF confere com seus digitos verificadores
                //calcula primeiro digito verificador
                int[] cpfInt = {Convert.ToInt32(cpf[0] + ""), 
                          Convert.ToInt32(cpf[1] + ""), 
                          Convert.ToInt32(cpf[2] + ""), 
                          Convert.ToInt32(cpf[3] + ""), 
                          Convert.ToInt32(cpf[4] + ""), 
                          Convert.ToInt32(cpf[5] + ""), 
                          Convert.ToInt32(cpf[6] + ""), 
                          Convert.ToInt32(cpf[7] + ""), 
                          Convert.ToInt32(cpf[8] + ""), 
                          Convert.ToInt32(cpf[9] + ""), 
                          Convert.ToInt32(cpf[10] + "")};
                int x = cpfInt[0] * 10 + cpfInt[1] * 9 + cpfInt[2] * 8 +
                        cpfInt[3] * 7 + cpfInt[4] * 6 + cpfInt[5] * 5 +
                        cpfInt[6] * 4 + cpfInt[7] * 3 + cpfInt[8] * 2;
                int r = x % 11;
                int d1 = 11 - r;
                if (r < 2)
                    d1 = 0;
                //calcula segundo digito verificador
                x = cpfInt[0] * 11 + cpfInt[1] * 10 + cpfInt[2] * 9 +
                    cpfInt[3] * 8 + cpfInt[4] * 7 + cpfInt[5] * 6 +
                    cpfInt[6] * 5 + cpfInt[7] * 4 + cpfInt[8] * 3 +
                    d1 * 2;
                r = x % 11;
                int d2 = 11 - r;
                if (r < 2)
                    d2 = 0;
                string meuDv = d1 + "" + d2;
                string cpfDv = cpf.Substring(9, 2);
                if (meuDv == cpfDv)
                {
                    retorno.Add(1);
                    retorno.Add(cpfInt[8] - 1);
                }
                else retorno.Add(0);
            }
            return retorno;
        }

        public string gerarcpf(int uf)
        {
            //Oito primeiros digitos aleatorios
            int[] cpfInt = new int[11];
            for (int i = 0; i < 8; i++)
                cpfInt[i] = rand.Next(0, 10);
            //Nono digito indica a UF emissora
            cpfInt[8] = uf;
            //Primeiro digito verificador
            int x = cpfInt[0] * 10 + cpfInt[1] * 9 + cpfInt[2] * 8 +
                    cpfInt[3] * 7 + cpfInt[4] * 6 + cpfInt[5] * 5 +
                    cpfInt[6] * 4 + cpfInt[7] * 3 + cpfInt[8] * 2;
            int r = x % 11;
            int d1 = 11 - r;
            if (r < 2)
                d1 = 0;
            cpfInt[9] = d1;
            //Segundo digito verificador
            x = cpfInt[0] * 11 + cpfInt[1] * 10 + cpfInt[2] * 9 +
                  cpfInt[3] * 8 + cpfInt[4] * 7 + cpfInt[5] * 6 +
                  cpfInt[6] * 5 + cpfInt[7] * 4 + cpfInt[8] * 3 +
                  cpfInt[9] * 2;
            r = x % 11;
            int d2 = 11 - r;
            if (r < 2)
                d2 = 0;
            cpfInt[10] = d2;
            string cpf = string.Join("", cpfInt);
            return cpf;
        }
    }

    class uf
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
