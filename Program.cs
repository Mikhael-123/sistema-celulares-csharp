using DesafioDIOCelular.Models;

Nokia nokia = new Nokia(modelo: "Modelo1", imei: "1111111", memoria: 2000);
nokia.Numero = "(00) 00000-0000";
Iphone iphone = new Iphone(modelo: "Modelo2", imei: "2222222", memoria: 1000);
iphone.Numero = "(00) 00000-0000";

nokia.InstalarAplicativo("Slither.io");
iphone.InstalarAplicativo("Apple music");

nokia.Ligar();
nokia.ReceberLigação();
iphone.Ligar();
iphone.ReceberLigação();