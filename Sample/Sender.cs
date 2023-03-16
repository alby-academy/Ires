namespace Sample;

public class Sender : SenderBase
{
    public string Name { get; set; }

    public Sender(AddressGateway gateway) : base(gateway)
    {
    }

    public override void Send()
    {
        var address = GetAddresses();
        Console.WriteLine(string.Join(", ", address));
    }
}