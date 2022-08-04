namespace circleStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius in miles: ");
            int radius = int.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            Console.WriteLine($"The area is {area}. The circumference is {circumference}. Diameter is {diameter}");

            Console.Write("How many miles per gallon does your car get? ");
            double mpg = double.Parse(Console.ReadLine());
            Console.WriteLine($"It will take {circumference / mpg} gallons to get around that dang circle");
        }
    } 
} 