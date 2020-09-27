using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura: {0} \n" + "Largura: {1}\n" + "Area: {2}\n" + "Perimetro:  {3}\n" + "Diagonal:  {4}\n ", retangulo.Altura, retangulo.Largura, retangulo.Area(), retangulo.Perimetro(), retangulo.Diagonal());
        }
    }
}
