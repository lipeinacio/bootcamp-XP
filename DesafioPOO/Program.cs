using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 1", imei: "10292222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Safari");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "09765443", modelo: "Modelo 2", imei: "12039487", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
