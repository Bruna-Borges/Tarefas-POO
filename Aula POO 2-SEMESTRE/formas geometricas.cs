using System;
namespace calculoarea
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double CalcularArea => Math.Pow(this.Raio, 2) * Math.PI;
    }
}
namespace CalcAreaPOO
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
    }
}
namespace CalcAreaPOO
{
    public class Retangulo : Forma
    {
        public double Lado { get; set; }
        public override double CalcularArea => this.Lado * this.Lado;
    }
}
namespace CalcAreaPOO
{
    public class Triangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea => (this.Base * this.Altura) / 2;
    }
}
