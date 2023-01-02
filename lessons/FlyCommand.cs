namespace lessons;

public class FlyCommand : BaseInteractCommand
{
    public override void Execute(string[] arguments)
    {
        var affectedDucks = GetAffectedDucks(arguments);
        foreach (var duck in affectedDucks)
        {
            duck.Fly();
        }
    }

    public override string GetHelpMessage()
    {
        return "Makes your duck fly";
    }
}