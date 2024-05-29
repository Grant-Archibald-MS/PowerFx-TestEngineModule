using Microsoft.Extensions.DependencyInjection;


namespace testengine.module
{
    public class PowerFxTestState {
        public ServiceCollection Services { get; set; } = new ServiceCollection();
        public ServiceProvider? Provider { get; set; }
    }
}