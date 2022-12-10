﻿using System;
using System.Collections.Generic;

public class Program
{
    private static List<Duck> _ducks = new List<Duck>();
    public static void Main(string[] args) 
    {
        Console.WriteLine("Now this is Duck Park !!! \r\nLet's take a look at our beautiful ducks:");
       
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

        foreach (var duck in _ducks)
        {
            Console.Write(duck.nickname + ", ");
        }

        Console.WriteLine("\nCount of ducks: {0}", _ducks.Count);
    }
}
