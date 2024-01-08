using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia Tijolo: ");
Smartphone nokia = new Nokia(numero: "1399999999", modelo:"Nokia 60", imei: "123456", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp..");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone 16: ");
Smartphone iphone = new Iphone(numero: "13988888888", modelo:"Iphone 16", imei: "654321", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram..");
