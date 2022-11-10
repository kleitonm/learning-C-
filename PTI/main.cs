using System;

class Program {
  public static void Main (string[] args) {
    string opcao = "S";
    while (opcao.Equals("S") || opcao.Equals("s")) {
      Console.Write("Preço do álcool: ");
      double alcool = double.Parse(Console.ReadLine());
      Console.Write("Preço do gasolina: ");
      double gasolina = double.Parse(Console.ReadLine());
      double combustivel = alcool / gasolina;
      if (combustivel > 0.7) {
        Console.WriteLine($"Vale a pena abastecer com gasolina");
      }
      else if (combustivel < 0.7) {
        Console.WriteLine($"Vale a pena abastecer com álcool");
      }
      else {
        Console.WriteLine($"Tanto faz abastecer com gasolina ou álcool");
      }
      Console.Write("Deseja fazer um novo cálculo de combustível (S/N)");
      opcao = Console.ReadLine();
    }
    Console.WriteLine("Fim do cálculo");
  }
}