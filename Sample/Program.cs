// See https://aka.ms/new-console-template for more information

using Sample;

Console.WriteLine("Hello, World!");

var gateway = new AddressGateway();
var sender = new Sender(gateway);

sender.Send();

Console.ReadKey();