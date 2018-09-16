using System;

namespace Test.CheckStringSymmetry.New
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("......Program checking string is Symetry........");

            IDataReader dataReader = new ConsoleDataReader();
            IStringCheckingHandlerFactory handlerFactory = new StringCheckingHandlerFactory();
            handlerFactory.AddHandler(new CheckingSymetryStringHandler());

            var process = new StringCheckingProcessor(dataReader, handlerFactory);
            var IsSuccess = process.Process();

            Console.WriteLine("Result checking: " + IsSuccess);
            Console.ReadLine();

        }
    }

}
