namespace lessons;

public class ClearDisplayCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.Clear();
    }

    public string GetHelpMessage()
    {
        return "Clear display";
    }
}