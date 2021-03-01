using System;
class Intervalo {
  static void Main() {
    Console.WriteLine("Insira o Intervalo Inicial: ");
    int interIni= Int32.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Intervalo Final: ");
    int interFim= Int32.Parse(Console.ReadLine());
    int intervalo=(interFim-interIni);
    if (intervalo > 15){
        Console.WriteLine("Intervalo Inválido!");
        }
    else{    
        Console.WriteLine(intervalo);
    }
  }
}