[ModificadorClasse] class NOME_DA_CLASSE {
  //Variáveis / propiedades 
  [EspedificadorAcesso] tipo NOME_DA_PROPIEDADE;

  //Métodos 
  [EspedificadorAcesso] retorno NOME_MÉTODO([arg1,arg2,...]) {
    //Corpo do método
  }
}

/*
ModificadorClasse: Define a visibilidade da classe:
  public: Pública, sem restrição de visualização;
  abstract: Classe=base para outras classes, não podem ser instanciados objetos 
            desta classe;
  sealed: Classe não pode ser herdada;
  static: Classe não permite a instanciação de objetos e seus membros devem ser 
          static;

EspecificadorAcesso: Onde um menbro da classe pode ser acessador: 
  public: Sem restrição de acesso;
  private: Só podem ser acessados pela própia classe;
  protected: Podem ser acessados na própia classe e nas classes derivados;
  abstract: Os métodos não tem implementação somente os cabeçalhos;
  sealed: O método não pode ser redefinido;
  virtual: O métodopode ser redefinido em uma classe derivada;
  static: O método pode ser chamado mesmo sem a instanciação de um objecto;
*/