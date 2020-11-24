class Program
    
	{
        static void Main(string[] args)
        
		{
            //Conta Criada pela SuperClasse Conta, dados os parametros 
            Conta acc= new Conta(1001, "Goku", 0.0);
	    //Conta Criada pela SubClasse ContaJuridica, dados os parametros	
            ContaJuridicabacc= new ContaJuridica(1002, "Goten", 0.0, 500.0);
		
            
		
            //UPCASTING
	    //Criação de um Objeto class Conta (acc1) e que herde todas as informações da SubClasse ContaJuridica (bacc)	
            Conta acc1 = bacc;
	    //Criação de um Objeto class Conta (acc2) e que herde todas as informações da SubClasse ContaJuridica parametros que estou colocando	
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
	    //Criação de um Objeto class Conta (acc3) e que herde todas as informações da SubClasse ContaPoupanca parametros que estou colocando
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);
            //DOWNCASTING
            ContaJuridica acc4 = (ContaJuridica)acc2;
            //acc4.Emprestimo(100.0);
	    //ContaPoupanca acc5 = (ContaPoupanca)acc3 	
            if(acc3 is ContaJuridica) 
	        
			{
	        ContaJuridicaacc5 = (ContaJuridica)acc3;
	        acc5.Emprestimo(200.0);
	        Console.WriteLine("Emprestimo!");
	        }
	   if(acc3 is ContaPoupanca)
	        
			{
		ContaPoupancaacc5 = acc3 as ContaPoupanca;
		acc5.atualizaSaldo();
		Console.WriteLine("Atualizado!");
			
			}
    }
}
