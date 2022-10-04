using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456789","C20", 88010201,32);
Smartphone iphone = new Iphone("987654321","14 pro", 222222222,64);

nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha");
nokia.MostrarNumero();
nokia.Numero = "88010201";
nokia.MostrarNumero();

iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();
