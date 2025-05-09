namespace S25W1CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int @double = 5;

            int i = 5;
            double d = 5.5;
            float f = 5.5F;
            decimal m = 5.5M;
            long l = 5L;

            var x = 5.5;


            Console.WriteLine(@"hello\nworld");
            Console.WriteLine("\n\n");



            int cars = 4, trucks = 3, bikes = 8;

            // string concatenation
            Console.WriteLine("There are " + cars + " cars, " + trucks + " trucks and " + bikes + " bikes");

            // string interpolation
            Console.WriteLine($"There are {cars} cars, {trucks} trucks and {bikes} bikes");
            Console.WriteLine("\n\n");



            int j = 5;
            int k = j;

            j++;

            Console.WriteLine(j);
            Console.WriteLine(k + "\n\n");


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            c1.radius = 40;
            Console.WriteLine(c1.radius);

            //Circle c2 = c1;
            Circle c2 = new Circle();
            Console.WriteLine(c2.radius);

            c2.radius = 100;
            Console.WriteLine(c1.radius);
        }
    }

    class Circle
    {
        public double radius;
    }
}
