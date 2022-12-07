using System;
using System.Collections.Generic;

public class Program
{
    private static List<Duck> _ducks = new List<Duck>();
    public static void Main(string[] args) 
    {
        Console.WriteLine("Now this is Duck Park !!!");
        _ducks.Add(new Duck()
        {
            nickname = "Bebe"
        });

        _ducks.Add(new Duck()
        {
            nickname = "Sergo"
        });

        Console.WriteLine("Count: {0}", _ducks.Count);
    }
}
