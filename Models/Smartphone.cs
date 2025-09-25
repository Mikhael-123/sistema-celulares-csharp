namespace DesafioDIOCelular.Models;

public abstract class Smartphone
{
  public Smartphone(string modelo, string imei, int memoria)
  {
    Modelo = modelo;
    IMEI = imei;
    Memoria = memoria;
  }

  public string Numero { get; set; }
  protected string Modelo { get; set; }
  protected string IMEI { get; set; }
  protected int Memoria { get; set; }

  public abstract void InstalarAplicativo(string nome);
  public void Ligar()
  {
    Console.WriteLine("Ligando...");
  }
  public void ReceberLigação()
  {
    Console.WriteLine("Você está recebendo uma chamada...");
  }
}
