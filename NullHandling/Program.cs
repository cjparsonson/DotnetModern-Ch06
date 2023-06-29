int thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!
WriteLine(thisCannotBeNull);
int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());


// The actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 7;
WriteLine(thisCouldAlsoBeNull);

Address address = new()
{
    Building = null,
    Street = null!, // ! is the null-forgiving operator
    City = "London",
    Region = "UK"
};

WriteLine(address.Building?.Length); // throws NullReferenceException ? fixes it (null conditional operator)
WriteLine(address.Street.Length); 
