namespace prjRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kets do some maths
            Console.WriteLine("Final COuntdown");
            //Recursion Method
            CountDown(5);

            //Lets try Factorial Maths
            Console.WriteLine("\nFactorial");
            int number = 5;
            int result = CalculateFactorial(number); //factorial looks like > 5
            Console.WriteLine();
}

        static void CountDown(int number)
        {
            //Base case: Whe will we stop??
            if (number == 0) //the condition that it will end the loop of recursion
            {
                Console.WriteLine("BlastOff");
                return;
            }

            //What will be printed out each time that the task is going to occur
            Console.WriteLine(number);

            //Recursion Case: Tye method (itself) is being call again 
            CountDown(number - 1);
        }
        static int CalculateFactorial(int number)
        {
            if(number <=1)
            {
                return 1;
            }
        
        }
    }
}
