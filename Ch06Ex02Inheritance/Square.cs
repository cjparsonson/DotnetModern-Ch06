using System.Security.Principal;

namespace Packt.Shape
{
    public class Square : Rectangle
    {
        // Default constructor
        public Square() { }

        // Constructor with parameters
        public Square(double side) : base(height: side, width: side) { }

        // Property overrides (as this is a square, we need to ensure that the height and width are always the same)
        public override double Height
        {
            set
            {
                height = value;
                width = value;
            }
        }

        public override double Width
        {
            set
            {
                height = value;
                width = value;
            }
        }


        // Area property implementation is inherited from Rectangle
       
    }
}
