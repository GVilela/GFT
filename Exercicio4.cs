using System;
class AreaCalculo {
  static void Main() {
    Console.WriteLine("Insira a inicial da figura a ser calculada (Q, R, C): ")
    string forma = Console.ReadLine();
    if (forma != "Q" || forma != "R" || forma != "C"){
        Console.WriteLine("Figura Inválida!");
    }
    if (forma == "Q"){
        Console.WriteLine("Insira o valor da lateral: ");
        int lado= Int32.Parse(Console.ReadLine());
        double areaQuadrado=(lado*lado)
        Console.WriteLine(areaQuadrado)
    }
        if (forma == "R"){
        Console.WriteLine("Insira o valor da largura: ");
        int largura= Int32.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor da altura: ");
        int altura= Int32.Parse(Console.ReadLine());
        double areaRetangulo=(largura*altura)
        Console.WriteLine(areaRetangulo)
    }
  }
}