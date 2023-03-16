namespace Sample;

public interface ISender
{
    void Send();

    public static string[] GetAddresses() => new[] { "add1", "add2", "add3" };
}