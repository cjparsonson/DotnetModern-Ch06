﻿using Packt.Shared;

partial class Program
{
    static void OutputPeopleNames(IEnumerable<Person?> people, string title)
    {
        WriteLine(title);
        foreach (Person? p in people)
        {
            WriteLine("  {0}",
                p is null ? "<null> Person" : p.Name ?? "<null> Name");
            /* if p is null then ouput: <null> Person
             * else output p.Name
             * Unless p.Name is null then output: <null> Name
             */   
        }
    }
}