using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone s1 = new Nokia("1234", "Modelo 1", "3333333", 64);

Console.WriteLine("Nokia:");
s1.Ligar();
s1.ReceberLigacao();
s1.InstalarAplicativo("Telegram");

Smartphone i1 = new Iphone("1245", "Modelo 2", "2222222", 128);
Console.WriteLine("Iphone:");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Twitter X");