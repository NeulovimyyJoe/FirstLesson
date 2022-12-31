namespace lessons;

public class FeedCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.WriteLine("You feed successfully!");
    }
}