using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("12345678","Tijolão","666666", 8);
Smartphone.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("87654321","14 Max","333333", 16);
Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");