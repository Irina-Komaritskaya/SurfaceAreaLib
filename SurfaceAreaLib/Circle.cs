namespace SurfaceAreaLib
{
    public class Circle: Figure
    {
        public double Radius { get; }
        
        public Circle(double radius)
        {
            if (IsNegativeNumber(radius))
            {
                throw new ArgumentException("Radius must be more then zero ");
            }

            Radius = radius;
        }

        public override double CalcSurfaceArea()
        {
            var surfaceArea = 2.0 * Math.PI * Radius * Radius;
            return surfaceArea;
        }
    }
}
