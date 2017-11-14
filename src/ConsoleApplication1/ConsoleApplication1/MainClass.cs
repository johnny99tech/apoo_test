using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
    class MainClass
    {
        //Visite estes enderecos para saber mais sobre validacao de CPF:
        //http://www.geradorcpf.com/
        //http://www.geradorcpf.com/algoritmo_do_cpf.htm
        public static void Main(string[] args)
        {
            ConsoleApplication1.Program p = new Program();
            ConsoleApplication1.uf ufs = new uf();

            int opcao;
            do
            {
                Console.WriteLine("\n** CPF APP - Menu **");
                Console.WriteLine("1 - Validar CPF");
                Console.WriteLine("2 - Gerar CPF");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                //**** VALIDAR CPF ****
                if (opcao == 1)
                {
                    Console.WriteLine("Informe o CPF (apenas digitos): ");
                    string cpf = Console.ReadLine();
                    List<int> resultado = p.validarcpf(cpf);
                    if (resultado[0] == 0) Console.WriteLine("CPF Invalido!");
                    else Console.WriteLine("CPF valido. UF de emissao: " + ufs.getuf(resultado[1]));
                }

                //**** GERAR CPF ****
                if (opcao == 2)
                {
                    Console.WriteLine("Informe a UF de emissao: ");
                    Console.WriteLine("1 para " + ufs.getuf(0));
                    Console.WriteLine("2 para " + ufs.getuf(1));
                    Console.WriteLine("3 para " + ufs.getuf(2));
                    Console.WriteLine("4 para " + ufs.getuf(3));
                    Console.WriteLine("5 para " + ufs.getuf(4));
                    Console.WriteLine("6 para " + ufs.getuf(5));
                    Console.WriteLine("7 para " + ufs.getuf(6));
                    Console.WriteLine("8 para " + ufs.getuf(7));
                    Console.WriteLine("9 para " + ufs.getuf(8));
                    Console.WriteLine("10 para " + ufs.getuf(9));
                    int uf = Convert.ToInt32(Console.ReadLine());
                    if (uf > 10) {
                        ufs.getuf(uf);
                    }
                    Console.WriteLine("CPF gerado: " + p.gerarcpf(uf));
                }
                else if(opcao > 2){
                    Console.WriteLine("Escolha uma opção válida!");
                }

            } while (opcao != 0);
        }
    }
}