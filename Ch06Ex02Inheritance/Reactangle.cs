namespace Packt.Shape
{
    public class Rectangle : Shape
    {
        // Default constructor
        public Rectangle() { }

        // Constructor with parameters
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width; 
        }

        // Area property implementation
        public override double Area
        {
            get
            {
                  return height * width;
            }
        }

    }
}
