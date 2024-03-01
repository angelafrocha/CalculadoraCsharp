using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp
{
    public class IUsuario
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------CALCULADORA----------");
            Console.WriteLine("\nEscolha uma das opções: " +
                              "\n1 - Soma" +
                              "\n2 - Subtração" +
                              "\n3 - Multipicação" +
                              "\n4 - Divisão" +
                              "\n0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Console.Clear(); OperacoesService.Soma(); break;
                case 2: Console.Clear(); OperacoesService.Subtracao(); break;
                case 3: Console.Clear(); OperacoesService.Multiplicacao(); break;
                case 4: Console.Clear(); OperacoesService.Divisao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;


            }
        }

    }
}