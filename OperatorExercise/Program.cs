namespace OperatorExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotenient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} x {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotenient} remainder {remainder}");

            Console.WriteLine($"Please enter the radius of the circle you want the area of.");
            double radius = double.Parse(Console.ReadLine() );
            Console.WriteLine(AreaOfCircle(radius));

        }
        public static double AreaOfCircle(double radius) 
        {
            
            var area = Math.PI * Math.Pow(radius, 2);
                return area;
        }
    }
}
