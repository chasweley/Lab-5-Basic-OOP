namespace Lab_5_Basic_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); //Create new object with radius 5

            //Prints information on circle's radius and area from method
            Console.WriteLine($"A circle with the radius {circle1.Radius} has the area {circle1.GetArea(circle1.Radius)}.");

            Circle circle2 = new Circle(6); //Create new object with radius 6

            //Prints information on circle's radius, area, volume and circumference from methods
            Console.WriteLine($"\nA circle with the radius {circle2.Radius} has:");
            Console.WriteLine($"Area: {circle2.GetArea(circle2.Radius)}");
            Console.WriteLine($"Volume: {circle2.GetVolume(circle2.Radius)}");
            Console.WriteLine($"Circumference: {circle2.GetCircumference(circle2.Radius)}");

            Console.WriteLine("\nAll calculations are rounded to two decimals.");
        }
    }
}