using System; 
public class Jogador {
  public int energia;
  public bool vivo;
  public string nome;

  public Jogador(string n) {
    energia = 100;
    vivo = true;
    nome = n;
  }

  ~Jogador() {
    Console.WriteLine("Jogador deletado!");
  }
}
class Aula29 {
  static void Main() {
    string nome1;

    Console.WriteLine("Digite o nome do jogador 1: ");
    nome1 = Console.ReadLine();

    Jogador j1 = new Jogador(nome1);
    Jogador j2 = new Jogador("Emanue");

    Console.WriteLine("Energia do Jogador 1: {0}", j1.nome);
  }
}