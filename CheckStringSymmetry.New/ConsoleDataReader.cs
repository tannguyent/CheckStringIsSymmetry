using System;

namespace Test.CheckStringSymmetry.New
{
    public class ConsoleDataReader : IDataReader
    {
        public string GetData()
        {
            Console.Write("Please input data:");
            var data = Console.ReadLine();
            return data;
        }
    }

}
