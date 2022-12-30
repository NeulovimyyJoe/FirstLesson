namespace lessons;

public class ClearDisplayCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.Clear();
    }
}