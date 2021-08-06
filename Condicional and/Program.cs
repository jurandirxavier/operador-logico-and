using System;

namespace Condicional_and
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("  Digite sua idade!");

            var idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("  Você é uma criança!!!");
            }
            else if(idade >= 12 && idade <= 18)
            {
                Console.WriteLine("  Você é um adolescente de " +idade+ " anos de idade");
            }
            else if(idade >= 19 && idade <= 50)
            {
                Console.WriteLine("  Parabéns!!! ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("  PARABÉNS!!! Você está na melhor idade");
            }
        }
    }
}
