namespace lessons;

public static class CommandBuilder
{
    public static Dictionary<string, ICommand> GetDefaultCommands()
    {
        var result = new Dictionary<string, ICommand>()
        {
            ["add"] = new AddDuckCommand(),
            ["display"] = new DisplayCommand(),
            ["clear_display"] = new ClearDisplayCommand(),
            ["feed"] = new FeedCommand()
        };
        return result;
    }
}