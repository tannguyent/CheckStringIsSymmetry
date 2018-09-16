using System;

namespace Test.CheckStringSymmetry.New
{
    public class CheckingSymetryStringHandler : IStringCheckingHandler
    {
        public bool Check(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("input string can not null");
            }

            var isSuccess = true;
            var length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                {
                    isSuccess = false;
                    break;
                }
            }

            return isSuccess;
        }
    }

}
