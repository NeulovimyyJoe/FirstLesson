namespace lessons;

public abstract class BaseInteractCommand : ICommand
{
    public abstract string GetSuccessResult(string[] arguments);

    public void Execute(string[] arguments)
    {
        //КАК НЕ НАДО ДЕЛАТЬ
        //
        // if (arguments.Length > 1)
        // {
        //     string duckName = arguments[1];
        //     List<Duck> affectedDucks = new List<Duck>();
        //     foreach (var duck in Program.ducks)
        //     {
        //         if (string.Equals(duckName, duck.nickname))
        //         {
        //             affectedDucks.Add(duck);
        //         }
        //     }
        //
        //     if (affectedDucks.Count > 0)
        //     {
        //         foreach (var affectedDuck in affectedDucks)
        //         {
        //             Console.WriteLine(GetSuccessResult);
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("NET UTOK");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("HUI");
        // }

        if (arguments.Length < 2)
        {
            Console.WriteLine("There is not enough arguments");
            return;
        }
        
        string duckName = arguments[1];
        List<Duck> affectedDucks = new List<Duck>();
        foreach (var duck in Program.ducks)
        {
            if (string.Equals(duckName, duck.nickname))
            {
                affectedDucks.Add(duck);
            }
        }
        
        if (affectedDucks.Count == 0)
        {
            Console.WriteLine($"We have no duck with this name - {duckName}");
            return;
        }
        
        Console.WriteLine(GetSuccessResult(arguments));
    }

    public abstract string GetHelpMessage();
}