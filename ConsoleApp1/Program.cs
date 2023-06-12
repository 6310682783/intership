// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World! Mr.Kantapat Kowadisai");
Console.WriteLine(".Netcore 7.0");
Console.WriteLine();

var car1 = new Car("Porche", "x1", 15000000.00, 2020);
var car2 = new Car("Honda", "jass", 600000.00, 2018);

car1.Whoami();
var pricecar1 = car1.Getprice();
Console.WriteLine($"price : {pricecar1}");
var taxcar1 = car1.Gettax();
Console.WriteLine($"tax : {taxcar1}");
Console.WriteLine();

car2.Whoami();
var pricecar2 = car2.Getprice();
Console.WriteLine($"price : {pricecar2}");
var taxcar2 = car2.Gettax();
Console.WriteLine($"tax : {taxcar2}");
Console.WriteLine();
