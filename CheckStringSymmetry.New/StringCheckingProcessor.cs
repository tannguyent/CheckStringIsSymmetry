using System.Collections.Generic;

namespace Test.CheckStringSymmetry.New
{
    public class StringCheckingProcessor : IBussinessProcess
    {
        private List<IStringCheckingHandler> _stringCheckings;
        private IDataReader _dataStore;
        private string _internalData;

        public StringCheckingProcessor(IDataReader dataStore, IStringCheckingHandlerFactory stringCheckingFactory)
        {
            _dataStore = dataStore;
            _stringCheckings = stringCheckingFactory.Build();
        }

        public string InternalData
        {
            get
            {
                if (string.IsNullOrEmpty(_internalData))
                    _internalData = _dataStore.GetData();
                return _internalData;
            }
        }

        public bool Process()
        {
            foreach (var handler in _stringCheckings)
            {
                if (!handler.Check(InternalData))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
