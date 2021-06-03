using System;

namespace test
{
    class Program
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;

        public static int Divide(int a, int b) 
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                throw new DivideByZeroException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Multiply(4,4));
            Console.WriteLine(Divide(24, 6));
            Console.WriteLine(Subtract(15, 3));
        }
    }
}
