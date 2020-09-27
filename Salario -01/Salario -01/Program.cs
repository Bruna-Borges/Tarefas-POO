using System;

namespace Salario__01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();

            Console.WriteLine("Nome do primeiro funcionario: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Salario do primeiro funcionario: ");
            p2.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Nome do segundo funcionario: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Salario do segundo funcionario: ");
            p2.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Media salarial: {0}", (p1.Salario + p2.Salario / 2));
        }
    }
}
