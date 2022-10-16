using System;
namespace EltonGauna
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("Insira o numero a ser fatorado:");
            int fatorial = int.Parse(Console.ReadLine());
            int numero = fatorial;
            int resultado = fatorial;
            if (fatorial == 0) resultado++;
            while (fatorial > 1)
            {
                resultado *= --fatorial;
            }

            Console.WriteLine("O resultado de "+numero+"! é: "+resultado);
            
        }
    }
}
