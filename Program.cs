using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Instanciando um objeto Nokia
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 512);

// Testando funcionalidades do Nokia
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.IMEI}");
Console.WriteLine($"Memória: {nokia.Memoria}MB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// Instanciando um objeto Iphone
Iphone iphone = new Iphone("987654321", "iPhone X", "987654321098765", 256);

// Testando funcionalidades do iPhone
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.IMEI}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");