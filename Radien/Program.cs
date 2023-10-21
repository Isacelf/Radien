namespace Radien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cirkelOne = new Circle (5, 3.141f);
            Circle cirkelTwo = new Circle (6, 3.141f);

            double areaOne = cirkelOne.getArea();
            double areaTwo = cirkelTwo.getArea();

            Console.WriteLine("The area of the circle with a radius of 5 is: " +areaOne);
            Console.WriteLine("The area of the circle with a radius of 6 is: " +areaTwo);



        }
    }
    class Circle
    {
        public float Pi = 3.141f;
        public int Radius;
        public Circle(int radius, float pi)
        {
            Radius = radius;
            Pi = pi;
        }
        public double getArea()
        {
            return Radius * Radius * Pi;
        }
    }
}