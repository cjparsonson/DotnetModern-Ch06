namespace Packt.Shape
{
    public class Circle : Square
    {
        // Default constructor
        public Circle() { }

        // Constructor with parameters (side inherited from Square)
        public Circle(double radius) : base(side: radius * 2) { }

        public double Radius
        {
            get
            {
                return height / 2;
            }
            set
            {
                Height = value * 2;
            }
        }

        // Area property implementation
        public override double Area
        {
            get
            {
                double radius = height / 2;
                return Math.PI * radius * radius;
            }
        }
    }
}
