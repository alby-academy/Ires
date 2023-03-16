namespace Sample;

public class Sender
{
    public bool Send(string suffix)
    {
        try
        {
            var address = new[] { "add1", "add2", "add3" }
                .Select(c => $"{suffix} {c}");
            
            Console.WriteLine(string.Join(", ", address));
        }
        catch
        {
            return false;
        }

        return true;
    }
}