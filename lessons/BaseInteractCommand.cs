namespace lessons;

public abstract class BaseInteractCommand : ICommand
{
    public List<Duck> GetAffectedDucks(string[] arguments)
    {
        if (arguments.Length < 2)
        {
            Console.WriteLine("There is not enough arguments");
            return null;
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
            return null;
        }

        return affectedDucks;
    }

    public abstract void Execute(string[] arguments);

    public abstract string GetHelpMessage();
}