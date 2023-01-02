namespace lessons;

public class AddDuckCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        // Console.WriteLine("Would you like to add a duck? Write in the console Yes or No please.");
        //
        // string answer1 = Console.ReadLine();
        //
        // if (answer1.ToLower() == "yes")
        // {
        //     Console.WriteLine("Give it a name:");
        //     Program.ducks.Add(new Duck()
        //     {
        //         nickname = Console.ReadLine()
        //     });
        //     Program.Save();
        // }

        if (arguments.Length < 2)
        {
            Console.WriteLine("Wrong command usage. Please type as : \"add name\"");
            return;
        }

        var duck = new Duck(arguments[1]);
        var duckWithSameName = Program.ducks.Where(cycleDuck => string.Equals(cycleDuck.nickname, arguments[1]));
        int count = duckWithSameName.Count();
        
        if (count > 0)
        {
            duck.displayName = $"{arguments[1]} ({count})";
            Program.ducks.Add(duck);
            return;
        }
        
        Program.ducks.Add(duck);
        
        // if (count > 0)
        //     duck.displayName = $"{arguments[1]} ({count})";
        // else
        //     duck.displayName = duck.nickname;
        //
        // Program.ducks.Add(duck);
        
        // duck.displayName = (count > 0) ? $"{arguments[1]} ({count})" : duck.nickname;
        // Program.ducks.Add(duck);
    }

    public string GetHelpMessage()
    {
        return "Adding your own duck";
    }
}