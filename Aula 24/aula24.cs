using System;
class Aula24 {
  static void Main() {
    int r;

    Console.Write("Digite o primeiro valor: ");
    int v1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    int v2 = Convert.ToInt32(Console.ReadLine());
    r=soma(v1, v2);

    Console.WriteLine("A soma de {0} e {1} é igual a: {2}", v1, v2, r);
  }

  static int soma(int n1, int n2) {
    int res = n1 + n2;
    
    return res;
  }
}