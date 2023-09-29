namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercise 1");
            Console.WriteLine();
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}.");
            }
            Console.WriteLine();

            Console.WriteLine("Exercise 2");
            Console.WriteLine();

            Console.WriteLine("What is the radius of your circle?");
            var radious = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radious of {radious} is {AreaOfCircle(radious)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
