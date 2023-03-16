namespace Sample;

public class Runner
{
    private readonly Func<string, bool> _sender;

    public Runner(Func<string, bool> sender)
    {
        _sender = sender;
    }

    public void Run() => _sender("Giulio");
}