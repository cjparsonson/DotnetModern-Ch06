﻿// See https://aka.ms/new-console-template for more information
Console.Write("Enter a name: ");
string? name = Console.ReadLine();
if (name is null)
{
    Console.WriteLine("Name cannot be null!");
    return;
}
Console.WriteLine($"Hello, {name} has {name.Length} characters.");


