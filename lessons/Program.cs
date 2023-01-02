using lessons;
using Newtonsoft.Json;

public class Program
{
    private static string savePath = "save.json";
    
    public static List<Duck> ducks = new List<Duck>();
    public static Dictionary<string, ICommand> commands;

    public static void Save()
    {
        File.WriteAllText(savePath, JsonConvert.SerializeObject(ducks));
    }

    private static bool TryInitFromSave()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            var result = JsonConvert.DeserializeObject<List<Duck>>(json);
            if (result != null)
            {
                ducks = result;
                return true;
            }
        }
        return false;
    }

    public static void DuckGeneration()
    {
        ducks.Add(new Duck("Bebe"));

        ducks.Add(new Duck("Sergo"));

        ducks.Add(new Duck("Himdan ibn Mohammed II"));

        ducks.Add(new Duck("Masha"));

        ducks.Add(new Duck("Spartacus"));

        ducks.Add(new Duck("Vladimir Miroshnikov"));

        ducks.Add(new Duck("Natalya Miroshnikova"));
        
    }

    public static void HandleInput()
    {
        Console.WriteLine("Enter command line... (\"help\" for example)");
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

        if (TryInitFromSave() == false)
        {
            DuckGeneration();
            Save();
        }

        Console.WriteLine("Now this is Duck Park !!! \r\nLet's take a look at our beautiful ducks:");
        
        while (true)
        {
            HandleInput();
        }
    }
}
