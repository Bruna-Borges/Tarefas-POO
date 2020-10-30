class Produto{
    static void Main(string[] args) {
        //Criando a variável de entrada
        int n = int.Parse(Console.ReadLine());
        //Criando vetor com o número da variável de entrada
        Produto [] vect= new Produto [n];
        //Utilização do comando for para percorrer o vetor
        for (int i  = 0; i < n; i++) {
            string Name= Console.ReadLine();
            double Price= double.Parse(Console.ReadLine(), CultureInfo, InvariantCulture);                
            //Entrada dos elementos no vetor pelo usuário
            vect[ i ] = new Produto {Name= name, Price= price}; 
        }
        //Variável soma       
        double sum = 0.0;
        //Utilização do for para percorrer o vetor
        for (int i = 0; i < n; i ++) {
            //Somatoria dos elementos inseridos
            sum += vect[ i ].Price;
            // Calculo da Media
            double avg = sum / n;
            Console.Write("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
