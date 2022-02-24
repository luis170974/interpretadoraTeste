using System;
using System.IO;

namespace interpretadoraTeste.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = @"
    s __ s __ s    s __ s __ s __ s __ s __ s __ 
   |s __|s __|s|__|s|__ s|__ s   |s|__|s|__|s|  |
   |s|__ s __|s   |s __|s|__|s   |s|__|s __|s|__|";

            StringReader texto = new StringReader(entrada);
            string linha1 = texto.ReadLine();
            string linha2 = texto.ReadLine();
            string linha3 = texto.ReadLine();
            string linha4 = texto.ReadLine();

            //Console.WriteLine(linha1 + "\n" + linha2 + "\n" + linha3 + "\n" + linha4);

            string[] strLinha2 = linha2.Split('s');
            string[] strLinha3 = linha3.Split('s');
            string[] strLinha4 = linha4.Split('s');

            string saida = "";

            for (int i = 0; i < strLinha3.Length; i++)
            {
                //condicional para ver que numero é:
                if (strLinha2[i] == "    " && strLinha3[i] == "   |" && strLinha4[i] == "   |")
                    saida += 1;

                else if (strLinha2[i] == " __ " && strLinha3[i] == " __|" && strLinha4[i] == "|__ ")
                    saida += 2;

                else if (strLinha2[i] == " __ " && strLinha3[i] == " __|" && strLinha4[i] == " __|")
                    saida += 3;

                else if (strLinha2[i] == "    " && strLinha3[i] == "|__|" && strLinha4[i] == "   |")
                    saida += 4;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "|__ " && strLinha4[i] == " __|")
                    saida += 5;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "|__ " && strLinha4[i] == "|__|")
                    saida += 6;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "   |" && strLinha4[i] == "   |")
                    saida += 7;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "|__|" && strLinha4[i] == "|__|")
                    saida += 8;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "|__|" && strLinha4[i] == " __|")
                    saida += 9;

                else if (strLinha2[i] == " __ " && strLinha3[i] == "|  |" && strLinha4[i] == "|__|")
                    saida += 0;
            }

            //===================================== aqui é só para apresentar sem os 'p' no meio
            string apresentarTexto = @"
      __   __        __   __   __   __   __   __ 
   |  __|  __| |__| |__  |__     | |__| |__| |  |
   | |__   __|    |  __| |__|    | |__|  __| |__|";

            System.IO.StringReader apresentacaoLeitor = new StringReader(apresentarTexto);
            string l1 = apresentacaoLeitor.ReadLine();
            string l2 = apresentacaoLeitor.ReadLine();
            string l3 = apresentacaoLeitor.ReadLine();
            string l4 = apresentacaoLeitor.ReadLine();
            Console.WriteLine(l1 + "\n" + l2 + "\n" + l3 + "\n" + l4);
            //=============================================================  até aqui

            //mostrando a saida:
            Console.WriteLine("\n\nO Número é: " + saida);

            Console.ReadKey();
        }
    }
    }

