namespace Figure
{
    public class Triangle : Figure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC)) 
            {
                throw new ArgumentException("Такой треугольник не возможен");
            }
                
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return Math.Round(area, 3);
        }

        public bool IsRightTriangle()
        {
            double[] sides = [sideA, sideB, sideC];
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return c * c == (a * a + b * b);
        }
    }
}