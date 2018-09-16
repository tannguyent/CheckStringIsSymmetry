using System;
using System.Collections.Generic;

namespace Test.CheckStringSymmetry.New
{
    public class StringCheckingHandlerFactory : IStringCheckingHandlerFactory
    {
        private List<IStringCheckingHandler> _stringCheckings;

        public StringCheckingHandlerFactory()
        {
            _stringCheckings = new List<IStringCheckingHandler>();
        }

        public void AddHandler(IStringCheckingHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException("handler can not null");
            }

            _stringCheckings.Add(handler);
        }

        public List<IStringCheckingHandler> Build()
        {
            return _stringCheckings;
        }
    }

}
