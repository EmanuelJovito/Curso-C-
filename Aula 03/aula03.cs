using System;
class Aula03 {
  static void Main() {
    // variaveis locais ao metodo Main
    int num = -1;
    byte num1 = 10; // byte só armazena entre 0 e 255
    char letra = 'e';
    float valor = 0.5f;
    string nome = "Emanuel Jovito";

    var aux = 10; // var: o tipo é atribuido durante a compilação 

    /*Console.WriteLine(num);
    Console.WriteLine(num1);
    Console.WriteLine(letra);
    Console.WriteLine(valor);
    Console.WriteLine(nome);
    Console.WriteLine(aux);*/

    int numSoma1, num2, res;

    numSoma1 = 2;
    num2 = 10;
    res = numSoma1 + num2;
    
    Console.WriteLine("A soma de " + numSoma1 + " mais " + num2 + " é igual a: " + res);
  }
}