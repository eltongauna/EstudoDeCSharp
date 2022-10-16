using System;
namespace EltonGauna
{
    class Programa
    {
        static void Main()
        {
            double nota = 0, peso = 0, media = 0, somaPeso = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Insira a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o peso da nota do aluno: ");
                peso = double.Parse(Console.ReadLine());
                somaPeso += peso;
                media = media + (nota * peso);
            }

            Console.WriteLine("A media final é de: " + media / somaPeso);
        }
    }
}
