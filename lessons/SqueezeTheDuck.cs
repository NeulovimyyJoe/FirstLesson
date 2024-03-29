﻿namespace lessons;

public class SqueezeTheDuck : BaseInteractCommand
{
    public override void Execute(string[] arguments)
    {
        var affectedDucks = GetAffectedDucks(arguments);
        foreach (var duck in affectedDucks)
        {
            Console.WriteLine($"{duck.displayName} was squeezed");
        }
    }

    public override string GetHelpMessage()
    {
        return "Let you squeeze the chosen duck";
    }
}