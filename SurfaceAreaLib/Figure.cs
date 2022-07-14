namespace SurfaceAreaLib
{
    public abstract class Figure
    {
        public abstract double CalcSurfaceArea();
        protected static bool IsNegativeNumber(double number)
        {
            return number <= 0 || double.IsNaN(number);
        }
    }
}
