using System.Collections.Generic;

namespace Test.CheckStringSymmetry.New
{
    public interface IStringCheckingHandlerFactory
    {
        void AddHandler(IStringCheckingHandler handler);
        List<IStringCheckingHandler> Build();
    }

}
