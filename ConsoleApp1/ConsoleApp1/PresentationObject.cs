﻿namespace ConsoleApp1;

public class PresentationObject
{
    public int width {get; set;}
    public int height {get; set;}

    public void Copy()
    {
        Console.WriteLine("object copied to clipboard");
    }

    public void Duplicate()
    {
        Console.WriteLine("object duplicated");
    }
}