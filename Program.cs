using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia\n");
Smartphone nokia = new Nokia(
    numero: "xxxxxxxxxxx",
    modelo: "Nokia G11 Plus",
    imei: "11111111",
    memoria: 128
);

Console.WriteLine("Características do Smartphone:\n");
Console.WriteLine($"Número: {nokia.Numero} \t Modelo: {nokia.Modelo} \t IMEI: {nokia.Imei} \t Memória: {nokia.Memoria}\n");

nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

Console.WriteLine("\nSmartphone Iphone\n");
Smartphone iphone = new Iphone(
    numero: "yyyyyyyyyyy",
    modelo: "Iphone 14",
    imei: "22222222",
    memoria: 256
);

Console.WriteLine("Características do Smartphone:\n");
Console.WriteLine($"Número: {iphone.Numero} \t Modelo: {iphone.Modelo} \t IMEI: {iphone.Imei} \t Memória: {iphone.Memoria}\n");
iphone.Ligar();
iphone.InstalarAplicativo("Waze");
iphone.ReceberLigacao();

