namespace lessons;

public class AddDuckCommand : ICommand
{
    public void Execute(string[] arguments)
    {
        Console.WriteLine("Would you like to add a duck? Write in the console Yes or No please.");
        
        string answer1 = Console.ReadLine();
        
        if (answer1.ToLower() == "yes")
        {
            Console.WriteLine("Give it a name:");
            Program.ducks.Add(new Duck()
            {
                nickname = Console.ReadLine()
            });
            Program.Save();
        }
    }

    public string GetHelpMessage()
    {
        return "Adding your own duck";
    }
}