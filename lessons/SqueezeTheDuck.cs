namespace lessons;

public class SqueezeTheDuck : BaseInteractCommand
{
    public override string GetSuccessResult(string[] arguments)
    {
        return $"{arguments[1]} was squeezed";
    }

    public override string GetHelpMessage()
    {
        return "Let you squeeze the chosen duck";
    }
}