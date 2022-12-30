namespace lessons;

public class DisplayCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        foreach (var duck in Program.ducks)
        {
            Console.Write(duck.nickname + ", ");
        }

        Console.WriteLine("\nCount of ducks: {0}", Program.ducks.Count);
    }
}