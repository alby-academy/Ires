// See https://aka.ms/new-console-template for more information

using Sample;

Console.WriteLine("Hello, World!");

var sender = new Sender();
var runner = new Runner(sender.Send);

runner.Run();

Console.ReadKey();