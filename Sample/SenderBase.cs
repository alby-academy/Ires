namespace Sample;

public abstract class SenderBase : ISender
{
    private readonly AddressGateway _gateway;
    protected SenderBase(AddressGateway gateway) => _gateway = gateway;

    protected string[] GetAddresses() => _gateway.GetPending();

    public abstract void Send();
}