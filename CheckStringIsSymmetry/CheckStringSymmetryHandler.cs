using System;

namespace Test.CheckStringIsSymmetry
{
    public class CheckStringSymmetryHandler : ICheckStringHandler
    {
        public bool Check(string stringNeedProcess)
        {
            if (string.IsNullOrEmpty(stringNeedProcess))
                throw new ArgumentNullException("input string can not null");

            var isValid = true;
            var lengthString = stringNeedProcess.Length;
            for (int i = 0; i < stringNeedProcess.Length / 2; i++)
            {
                if (stringNeedProcess[i] != stringNeedProcess[lengthString - i - 1])
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}

