using System;
namespace EltonGauna;
class Programa
{
    static void Main()
    {
        Console.WriteLine("Informe o ano:");
        int ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o mes:");
        int mes = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Informe o dia:");
        int dia = int.Parse(Console.ReadLine());
        if(ano >= 1900 && ano <= 2999)
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (dia <= 31)
                        Console.WriteLine("Data Válida");
                    else
                        Console.WriteLine("Data Inválida");
                    break;
                case 4:    
                case 6: 
                case 9:
                case 11:    

                    if (dia <= 30)
                        Console.WriteLine("Data Válida");
                    else
                        Console.WriteLine("Data Inválida");
                    break;
                case 2:
                    if (dia <= 29)
                        Console.WriteLine("Data Válida");
                    else
                        Console.WriteLine("Data Inválida");
                    break;
                default:
                    Console.WriteLine("Data Inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Data Inválida");
        }
    }
}