using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[30];
        Random random = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(1, 11); 
        }

        Console.WriteLine("--- Vetor Gerado ---");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }
        Console.WriteLine("\n\n--- Contagem de Números ---");

        bool[] jáContado = new bool[30];

        for (int i = 0; i < vetor.Length; i++)
        {
            if (jáContado[i] == true)
                continue;

            int contador = 1;

            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[i] == vetor[j])
                {
                    contador++;
                    jáContado[j] = true; 
                }
            }

            Console.WriteLine($"O número {vetor[i]} aparece {contador} vez(es).");
        }
    }
}
