using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testes Smartphone Nokia");

var nokia = new Nokia { Numero = "123456" , IMEI = "12345", Memoria = 64, Modelo = "abc123"};
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


var iphone = new Iphone { Numero = "4321", IMEI = "12345", Memoria = 64, Modelo = "1234FGH" };
