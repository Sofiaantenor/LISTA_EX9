using System;

namespace AMS_Ex9_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1 = 51;
            double v2 = 5;
            
            Console.WriteLine("");
            Console.WriteLine("        ***CÁLCULO DO RESTO DE UMA DIVISÃO ENTRE DOIS VALORES***      ");
            
            double resto = v1 % v2;

            if (v2 == 0)
            {
               Console.WriteLine("Não é possível realizar uma divisão por 0!");
            }
            else
            {
               Console.WriteLine($"O resto da divisão entre {v1} e {v2} é {resto}");
            }

            Console.WriteLine("");
        }
    }
}
