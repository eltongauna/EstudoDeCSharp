using System;
namespace EltonGauna
{
    class Programa
    {
        static void Main()
        {
            double nota = 0, peso = 0, media = 0, somaPeso = 0;
            Console.WriteLine("Insira a quantidade de notas a ser lida do aluno: ");
            int notas = int.Parse(Console.ReadLine());
            for (int i = 0; i < notas; i++)
            {
                Console.WriteLine("Insira a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                if(nota == -1) { break; }

                Console.WriteLine("Insira o peso da nota do aluno: ");
                peso = double.Parse(Console.ReadLine());
        
                somaPeso += peso;
                media = media + (nota * peso);
            }
            Console.WriteLine("A media final é de: " + media / somaPeso);
        }
    }
}
