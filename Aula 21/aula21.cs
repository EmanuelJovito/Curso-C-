using System;
class Aula21 {
  static void Main() {
    string senha = "123";
    string senhaUser;
    int tentativas = 0;

    do {
      Console.Clear();
      Console.Write("Digite a senha: ");
      senhaUser = Console.ReadLine();
      tentativas ++;
    } while(senha != senhaUser);

    Console.Clear();
    Console.WriteLine("Senha correta, tentativas: {0}", tentativas);
  }
}