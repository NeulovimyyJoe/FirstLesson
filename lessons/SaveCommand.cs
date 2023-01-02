namespace lessons;

public class SaveCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Program.Save();
        Console.WriteLine("Saved successfully");
    }

    public string GetHelpMessage()
    {
        return "Save progress";
    }
}