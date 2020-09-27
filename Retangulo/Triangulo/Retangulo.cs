using System;
namespace Retangulo
{
	class Retangulo
    {
        public string retangulo;
        public double Largura;
        public double Altura;

        public double Area()
        {
            return this.Largura * this.Altura;
        }

        public double Perimetro()
        {
            return (2 * this.Largura) + (2 * this.Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(this.Largura, 2) + Math.Pow(this.Altura, 2));
        }
    }
}

