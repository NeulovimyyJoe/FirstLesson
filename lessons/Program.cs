using lessons;

public class Program
{
    public static List<Duck> ducks = new List<Duck>();
    private static Dictionary<string, ICommand> commands;

    public static void DuckGeneration()
    {
         ducks.Add(new Duck()
        {
            nickname = "Bebe"
        });

        ducks.Add(new Duck()
        {
            nickname = "Sergo"
        });

         ducks.Add(new Duck()
        {
            nickname = "Himdan ibn Mohammed II"
        });

        ducks.Add(new Duck()
        {
            nickname = "Masha"
        });
        ducks.Add(new Duck()
        {
            nickname = "Spartacus"
        });

        ducks.Add(new Duck()
        {
            nickname = "Vova"
        });

        ducks.Add(new Duck()
        {
            nickname = "Natasha"
        });
    }

    public static void HandleInput()
    {
        Console.WriteLine("Enter command line...");
        string input = Console.ReadLine();
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string commandWord = words[0].ToLower();
        if (commands.ContainsKey(commandWord))
        {
            var neededCommand = commands[commandWord];
            neededCommand.Execute(words);
        }
        else
        {
            Console.WriteLine("There is no such command. Try again.");
        }
    }
    
    public static void Main(string[] args)
    {
        commands = CommandBuilder.GetDefaultCommands();

        Console.WriteLine("Now this is Duck Park !!! \r\nLet's take a look at our beautiful ducks:\n");

        DuckGeneration();

        while (true)
        {
            HandleInput();
        }
    }
}
