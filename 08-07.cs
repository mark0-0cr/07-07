using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];

       
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        
        int maior = vetor[0];
        int menor = vetor[0];

        
        for (int i = 1; i < 10; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }

            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        
        Console.WriteLine($"\nMaior valor: {maior}");
        Console.WriteLine($"Menor valor: {menor}");
    }
}
