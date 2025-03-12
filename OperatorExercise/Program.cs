namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            
            //exercise 2
            Console.WriteLine("Input a value for the radius of the circle: ");
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"Area of the circle is: {area}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

