using System;
class NumerosDivisiveis {
  static void Main() {
    Console.WriteLine("Insira o valor a ser testado: ");
	int numero = Int32.Parse(Console.ReadLine());	
	if (numero >= 10 && numero <= 215){
        if (numero % 3==0 && numero % 7 == 0) {
            Console.WriteLine("Número Divisível por 3 e 7!");
            
        } 
        else {
            Console.WriteLine("Numero Inválido!");
        }
	}
	else{
	    Console.WriteLine("Número Inválido!");
	   
	}
  }
}