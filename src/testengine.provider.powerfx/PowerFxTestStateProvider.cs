using Microsoft.PowerApps.TestEngine.Providers;
using testengine.module;

namespace testengine.provider.powerfx
{
    public class PowerFxTestStateProvider : ITestProviderState
    {
        PowerFxTestState _state = new PowerFxTestState();

        public object GetState()
        {
            return _state;
        }
    }
}
