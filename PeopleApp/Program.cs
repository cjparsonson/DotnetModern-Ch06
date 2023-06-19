﻿using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};
harry.WriteToConsole();

// non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gawmma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // lookup a value which has 2 as its key
WriteLine(format: "key: {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]);

// Lookup value with harry as its key
WriteLine(format: "key: {0} has value: {1}",
    arg0: harry,
    arg1: lookupObject[harry]);

// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "key: {0} has value: {1}",
   arg0: key,
   arg1: lookupIntString[key]);
