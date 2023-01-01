namespace lessons;

public class DisplayCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        string displayLine = string.Empty;
        foreach (var duck in Program.ducks)
        {
            displayLine += duck.nickname + ", ";
        }

        displayLine = displayLine.Trim(new[] { ',', ' ' });
        displayLine += ".";
        Console.WriteLine(displayLine);
        Console.WriteLine("\nCount of ducks: {0}", Program.ducks.Count);
    }

    public string GetHelpMessage()
    {
        return "Display all ducks";
    }
}