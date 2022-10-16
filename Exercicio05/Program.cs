using System;
namespace EltonGauna;
class Programa
{
    static void Main()
    {
        
        int numA = 0, numB = 1, num;
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(numA);   
            num = numA+numB;
            numB = numA;
            numA = num;

        }
     
    }
}

