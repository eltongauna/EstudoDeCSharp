using System;
namespace EltonGauna
{
    class Programa
    {
        static void Main()
        {
            int soma = 0;
            Console.WriteLine("Atividade 03.1");
            for(int i = 10; i < 26; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Atividade 03.2");
            for (int j = 0; j <= 100; j++)
            {
                //if (j % 2 != 0)
                //{
                    soma = soma + j;
                //}
            }
            Console.WriteLine("Soma dos números impares de 0 a 100: " + soma);
            Console.WriteLine();
            Console.WriteLine("Atividade 03.3");
            soma = 0;
            for (int y = 0; y <= 100; y++)
            {
                if (y % 2 == 0)
                {
                    soma = soma + y;
                    if (soma > 100)
                    {
                        soma = soma - y;
                        break;
                    }
                    Console.WriteLine(y);
                }
            }
            Console.WriteLine("Soma dos números pares de 0 até X onde sejam menor que 100: " + soma);
            Console.WriteLine();
            Console.WriteLine("Atividade 03.4");
            for(int x=0; x <= 10; x++)
            {
                Console.WriteLine("9 x " + x +" = " + 9*x);
            }
        }
    }
}