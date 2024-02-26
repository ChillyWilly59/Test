namespace Figure
{
    public class Circle : Figure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (!IsValidCircle(radius))
            {
                throw new ArgumentException("Такой круг возможен");
            }

            this.radius = radius;
        }

        public static bool IsValidCircle(double radius)
        {
            return radius > 0;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return Math.Round(area, 3);
        }
    }
}