namespace Packt.Shared
{
    public class Person : Object
    {
        // Properties
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
    }
}