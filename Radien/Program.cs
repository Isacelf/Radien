// Isac Elfstrand SUT23
namespace Radien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cirkelOne = new Circle (5, 3.141f); // Skapar två circle-objekt med radien 5 och 6 samt pi värdet.
            Circle cirkelTwo = new Circle (6, 3.141f);

            double areaOne = cirkelOne.getArea(); // Berkäknar området för de två cirklarna med hjälp av getArea funktionen.
            double areaTwo = cirkelTwo.getArea();

            Console.WriteLine("The area of the circle with a radius of 5 is: " +areaOne); // Skriver ut resultatet till användaren
            Console.WriteLine("The area of the circle with a radius of 6 is: " +areaTwo);



        }
    }
    class Circle // Circle klassen
    {
        public float Pi = 3.141f; // Värdet för pi
        public int Radius; // Radien för cirkeln
        public Circle(int radius, float pi) // Constructor för att skapa en cirkel med en given radie samt pi
        {
            Radius = radius;
            Pi = pi;
        }
        public double getArea() // Funktionen för att räkna ut arean av cirkeln baserat på pi samt radie värdet.
        {
            return Radius * Radius * Pi;
        }
    }
}