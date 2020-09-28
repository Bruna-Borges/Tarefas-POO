using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Informe o aluno: ");
            aluno.nome = Console.ReadLine();

            do
            {
                Console.WriteLine("Informe a primeira nota: ");
                aluno.nota_1 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_1 < 0 || aluno.nota_1 > 30);

            do
            {
                Console.WriteLine("Informe a segunda nota: ");
                aluno.nota_2 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_2 < 0 || aluno.nota_2 > 35);

            do
            {
                Console.WriteLine("Informe a terceira nota: ");
                aluno.nota_3 = double.Parse(Console.ReadLine());
            }
            while (aluno.nota_3 < 0 || aluno.nota_3 > 35);

            if (aluno.SomaNota() >= 60)
            {
                Console.WriteLine("Aluno aprovado.\nPontução do aluno: " + aluno.SomaNota() + " pontos.");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado.\nFaltaram: " + (100 - aluno.SomaNota()) + " pontos.");
            }
        }
    }
}
