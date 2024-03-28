using UiPath.CodedWorkflows;

namespace TSDO
{
    public class ConnectionsManager
    {
        private ICodedWorkflowsServiceContainer _resolver;
        public ConnectionsManager(ICodedWorkflowsServiceContainer resolver)
        {
            _resolver = resolver;
        }
    }
}