namespace Packt.Shared
{
    public class Person : Object, IComparable<Person?>
    {
        // Properties
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // delegate field
        public event EventHandler? Shout;
        // data field
        public int AngerLevel;
        // method
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening...
                if (Shout != null)
                {
                    // Call the delegate
                    Shout(this, EventArgs.Empty);
                }
            }
        }
    }
}