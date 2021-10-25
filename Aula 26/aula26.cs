using System;
class Aula25 {
  static void Main() {
    int divid, divis, quoc, rest;

    Console.Write("Digite o primeiro valor: ");
    divid = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o segundo valor:");
    divis = Convert.ToInt32(Console.ReadLine());
    quoc = divide(divid, divis, out rest);

    Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", divid, divis, quoc, rest);
  }

  static int divide(int dividendo, int divisor, out int resto) {
    int quociente;
    quociente = dividendo / divisor;
    resto = dividendo % divisor;
    return quociente;
  }
}