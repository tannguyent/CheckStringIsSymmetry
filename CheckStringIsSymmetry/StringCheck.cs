using System.Collections.Generic;

namespace Test.CheckStringIsSymmetry
{
    public class StringCheck
    {
        private List<ICheckStringHandler> _handlers;
        public StringCheck()
        {
            _handlers = new List<ICheckStringHandler>();
        }
        public void AddHandler(ICheckStringHandler handler)
        {
            if (handler != null)
            {
                _handlers.Add(handler);
            }
        }

        public bool Check(string stringNeedProcess)
        {
            bool isResult = false;
            foreach (var handler in _handlers)
            {
                isResult = handler.Check(stringNeedProcess);
            }

            return isResult;
        }
    }
}

