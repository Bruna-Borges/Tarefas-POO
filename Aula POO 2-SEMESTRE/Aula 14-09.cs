    class Program
    {
        static void Main(string[] args)
        {
            double reais = 0;
            double taxa = 5.28d;
            double dolar = 0;

            Console.WriteLine("\nBem-Vindo\n");
            Console.Write("\nEntre com o valor em dólar : ");
            dolar = double.Parse(Console.ReadLine()); // lê o dolar

            // processamento do valor em reais
            reais = taxa * dolar;

            // saída ou solução
            Console.Write("Valor em Reais : $R" + reais);

            // espera entrada do teclado para encerrar programa
            Console.ReadKey();
        }
    }
}
