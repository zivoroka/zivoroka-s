﻿using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Write("Enter your First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your Last name: ");
        string LastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("{0} {1}", firstName, LastName);
    }
}