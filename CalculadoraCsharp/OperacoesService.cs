using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCsharp
{
    internal class OperacoesService
    {
        public static void Soma()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"A o resultado da soma é {a + b}");
        }
        public static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da subtração é {a - b}");
        }
        public static void Multiplicacao ()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da divisão é {a * b}");
        }
        public static void Divisao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float b = float.Parse(Console.ReadLine());

            if ( b != 0)
            {
                Console.WriteLine($"O resultado da divisão é {a / b}");
            }
            else
            {
                Console.WriteLine("A divisão por zero não é possível");
            }
        }

    
    }
}
