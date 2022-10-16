using System;
namespace EltonGauna;
class Programa
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        while (numero < 1000)
        {
            if(numero%2 == 0)
            {
                numero += 5;
                Console.WriteLine(numero);
            }
            else
            {
                numero *= 2;
                Console.WriteLine(numero);
            }
        }
    }
}