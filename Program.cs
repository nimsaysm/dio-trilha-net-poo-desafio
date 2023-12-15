using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nUsando smartphone Nokia...\n");
Smartphone nokia = new Nokia("1234", "Modelo antigo", "123456789", 64);
nokia.Ligar("40028922");
nokia.InstalarAplicativo("WhatsApp", 10);

Console.WriteLine("\nUsando smartphone Iphone...\n");
Smartphone iphone = new Iphone("14", "Novo iphone", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook", 8);