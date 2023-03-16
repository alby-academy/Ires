namespace Sample;

public class Sender : ISender
{
    public void Send()
    {
        var address = ISender.GetAddresses();
        Console.WriteLine(string.Join(", ", address));
    }
}