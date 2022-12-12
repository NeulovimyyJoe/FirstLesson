using System;
using System.Collections.Generic;

public class Program
{
    private static List<Duck> _ducks = new List<Duck>();
   
    public static void DuckEnterprise() 
    { 
        foreach (var duck in _ducks)
        {
            Console.Write(duck.nickname + ", ");
        }

        Сonsole.WriteLine("\nCount of ducks: {0}", _ducks.Count);
    }
   
    public static void DuckGeneration()
    {
         _ducks.Add(new Duck()
        {
            nickname = "Bebe"
        });

        _ducks.Add(new Duck()
        {
            nickname = "Sergo"
        });

         _ducks.Add(new Duck()
        {
            nickname = "Himdan ibn Mohammed II"
        });

        _ducks.Add(new Duck()
        {
            nickname = "Masha"
        });
        _ducks.Add(new Duck()
        {
            nickname = "Spartacus"
        });

        _ducks.Add(new Duck()
        {
            nickname = "Vova"
        });

        _ducks.Add(new Duck()
        {
            nickname = "Natasha"
        });
    }
    
    public static void Main(string[] args) 
    {
            
        Console.WriteLine("Now this is Duck Park !!! \r\nLet's take a look at our beautiful ducks:");

        DuckGeneration();

        DuckEnterprise();

        SuggestMeADuck();

    }
    
    public static void SuggestMeADuck()
    {
        Console.WriteLine("Would you like to add a duck? Write in the console Yes or No please.");
            
        string answer1;
            
        answer1 = Console.ReadLine();
           
        switch (answer1)
            {
            case "Yes": Console.WriteLine("Give it a name");
                _ducks.Add(new Duck()
                {
                    nickname = Console.ReadLine()
                });
                break;
            case "No": Console.WriteLine("Welcome dear Guest!");
                break;
                default: goto case "No";
    }       }   
}
