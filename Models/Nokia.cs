namespace DesafioDIOCelular.Models;

public class Nokia : Smartphone
{
  public Nokia(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
  {
    
  }

  public override void InstalarAplicativo(string nome)
  {
    Console.WriteLine($"Nokia está instalando o aplicativo '{nome}'...");
  }
}
