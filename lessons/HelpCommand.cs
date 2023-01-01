namespace lessons;

public class HelpCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.Clear();
        foreach (var keyValuePair in Program.commands)
        {
            Console.WriteLine($"{keyValuePair.Key} === {keyValuePair.Value.GetHelpMessage()}");
        }
    }

    public string GetHelpMessage()
    {
        return "Shows all commands and their functions";
    }
}