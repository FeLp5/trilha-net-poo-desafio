using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "168548", modelo: "Modelo Y Pro", imei: "094536049", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "168984", modelo: "Modelo X Plus", imei: "078538245", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();