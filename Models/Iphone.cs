namespace DesafioDIOCelular.Models;

public class Iphone : Smartphone
{
  public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
  {
    
  }

  public override void InstalarAplicativo(string nome)
  {
    Console.WriteLine($"Iphone está instalando o aplicativo '{nome}'...");
  }
}
