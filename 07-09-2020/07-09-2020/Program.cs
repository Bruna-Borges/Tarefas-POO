using System;

namespace _07_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno X = new Aluno();
            float n1, n2, n3, soma, reprovado;

            Console.WriteLine("Escreva o nome do aluno");
            X.Nome = Console.ReadLine();

            Console.WriteLine("Escreva as três notas");

            n1 = float.Parse(Console.ReadLine());

            n2 = float.Parse(Console.ReadLine());

            n3 = float.Parse(Console.ReadLine());

            int limite2 = 35;

            if ( n2 > 35)
            {
                n2 = limite2;
            }

            if (n3 > 35)
            {
                n3 = limite2;
            }

            soma = n1 + n2 + n3;
            reprovado = 60 - soma;

            Console.WriteLine("Nata final:" + soma);

            if (soma >= 60)
            {
                Console.WriteLine("Aprovado");

            }

            else
            {
                Console.WriteLine("Reprovado \n" + "Faltam" + reprovado + "Pontos");
            }

        }
    }
}
