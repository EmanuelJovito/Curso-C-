using System;
class Aula10 {
  enum DiasSemana {
    Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado 
  }
  static void Main() {
    DiasSemana ds = (DiasSemana)4;

    int ds1 = (int)DiasSemana.Sexta;

    Console.WriteLine(ds1);
  }
}