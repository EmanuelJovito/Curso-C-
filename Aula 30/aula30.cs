using System; 
public class Jogador {
  public int energia;
  public bool vivo;
  public string nome;

  public Jogador() {
    energia = 100;
    vivo = true;
    nome = "Emanuel";
  }
  public Jogador(string n) {
    energia = 100;
    vivo = true;
    nome = n;
  }
  public Jogador(string n, bool v) {
    energia = 100;
    vivo = v;
    nome = n;
  }
  public Jogador(string n, bool v, int e) {
    energia = e;
    vivo = v;
    nome = n;
  }

  public void info() {
    Console.WriteLine("Nome jogador...: {0}", nome);
    Console.WriteLine("Energia jogador: {0}", energia);
    Console.WriteLine("Status jogador.: {0}", vivo);
  }
  ~Jogador() {
    Console.WriteLine("Jogador deletado!");
  }
}
class Aula30 {
  static void Main() {
    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador("Emanue");
    Jogador j3 = new Jogador("Emanue");
    Jogador j4 = new Jogador("Emanue");

    j1.info();
    j2.info();
    j3.info();
    j4.info();
  }
}