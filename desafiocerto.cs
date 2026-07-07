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
        Console.WriteLine("\n\n--- Proporção de Cada Número ---");

        bool[] jaContado = new bool[30];

        for (int i = 0; i < vetor.Length; i++)
        {
            if (jaContado[i] == true)
                continue;

            int contador = 1;

            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[i] == vetor[j])
                {
                    contador++;
                    jaContado[j] = true; 
                }
            }

            double porcentagem = (contador / 30.0) * 100;

            Console.WriteLine($"O número {vetor[i]} representa {porcentagem:F2}% do vetor.");
        }
    }
}

