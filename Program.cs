using DesafioPOO.Models;

Console.WriteLine("Nokia...");
Console.WriteLine();
Nokia nokia = new Nokia("123-252", "Nokia 3310", "123456789", 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine();
Console.WriteLine("Iphone: ");
Console.WriteLine();

Iphone iphone = new Iphone("321-654", "Iphone 32", "789456123", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iCloud");
