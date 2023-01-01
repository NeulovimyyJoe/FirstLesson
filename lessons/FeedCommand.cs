namespace lessons;

public class FeedCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.WriteLine("You feed successfully!");
    }

    public string GetHelpMessage()
    {
        return "Let you feed your duck";
    }
}