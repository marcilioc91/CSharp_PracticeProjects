﻿namespace ExercicioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i > 1)
                    Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }
        }
    }
}