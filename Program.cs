using System;

namespace swappingTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer1 = 5;    //two different integer variable is swapping without third variable
            int integer2 = 4;

            integer1 = integer1 * integer2;
            integer2 = integer1 / integer2;
            integer1 = integer1 / integer2;

            Console.WriteLine("First number is "+integer1+"\nSecond number is "+integer2);
        }
    }
}
