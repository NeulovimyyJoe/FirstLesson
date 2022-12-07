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
            nickname = "Bebe",
            weight = 720
        });

        _ducks.Add(new Duck()
        {
            nickname = "Sergo",
            weight = 900
        });

        foreach(var duck in _ducks)
            {
                Console.WriteLine($"Name: {duck.nickname}");
                Console.WriteLine($"Weight: {duck.weight}");
            }
           
            Console.WriteLine("Count: {0}", _ducks.Count);
    }
}
