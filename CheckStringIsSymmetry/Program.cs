using System;

namespace Test.CheckStringIsSymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input string to test: ");
            var stringTest = Console.ReadLine();

            var checkProcessor = new StringCheck();
            checkProcessor.AddHandler(new CheckStringSymmetryHandler());
            var result = checkProcessor.Check(stringTest);

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}

