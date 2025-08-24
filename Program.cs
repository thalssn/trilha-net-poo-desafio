using DesafioPOO.Models;

//Implementado

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "8498765-4321", modelo: "N8", imei: "11223344", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "8594321-9876", modelo: "16 Pro", imei: "55667788", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");