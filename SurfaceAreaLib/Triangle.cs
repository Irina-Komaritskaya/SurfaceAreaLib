namespace SurfaceAreaLib
{
    public class Triangle : Figure
    {
        // a, b and c -  sides of triangle
        public double A { get;}
        public double B { get;}
        public double C { get;}

        public Triangle(double a, double b, double c)
        {
            if  (IsNegativeNumber(a) || IsNegativeNumber(b) || IsNegativeNumber(c))
            {
                throw new ArgumentException("All numbers must be more zero ");
            }
            A = a;
            B = b;
            C = c;
            
            if (!IsValid())
            {
                throw new ArgumentException("The lines do not form a triangle");
            }
        }

        private bool IsValid()
        {
            return A <= (B + C) 
                && B <= (A + C) 
                && C <= (A + B);
        }

        public bool IsRightTriangle()
        {
            return C * C == (A * A + B * B) 
                || A * A == (C * C + B * B) 
                || B * B == (A * A + C * C);
        }
            
        public override double CalcSurfaceArea()
        {
            // formula - https://www.omnicalculator.com/math/herons-formula
            var s = (A + B + C) / 2.0;
            var surfaceArea = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return surfaceArea;
        }

    }
}
