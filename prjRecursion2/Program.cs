namespace prjRecursion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number");
            
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("factoral of" + number + "=" + factorial.ToString());
        }

        public static double Factorial (int number)
        {
            if(number == 0)
            {
                return 1;
            }
            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
