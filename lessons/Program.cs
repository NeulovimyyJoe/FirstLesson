using System;
using System.Collections.Generic;

public class Program
{
    private List<Duck> _ducks = new List<Duck>();
    public void Main(string[] args) 
    {
        Console.WriteLine("Now this is Duck Park !!!");
        _ducks.Add(new Duck());
    }
}
