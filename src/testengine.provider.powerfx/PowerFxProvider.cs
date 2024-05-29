﻿using Microsoft.PowerApps.TestEngine.Config;
using Microsoft.PowerApps.TestEngine.Providers;
using Microsoft.PowerApps.TestEngine.Providers.PowerFxModel;
using Microsoft.PowerApps.TestEngine.TestInfra;
using Microsoft.PowerFx.Types;
using System.ComponentModel.Composition;
using testengine.provider.powerfx;

namespace testengineine.model
{
    [Export(typeof(ITestWebProvider))]
    public class PowerFxProvider : ITestWebProvider
    {
        public ITestInfraFunctions? TestInfraFunctions { get; set; }
        public ISingleTestInstanceState? SingleTestInstanceState { get; set; }
        public ITestState? TestState { get; set; }

        public ITestProviderState? ProviderState { get; set; } = new PowerFxTestStateProvider();

        public string Name => "powerfx";

        public string CheckTestEngineObject => "";

        public Task<bool> CheckIsIdleAsync()
        {
            return Task.FromResult(true);
        }

        public Task CheckProviderAsync()
        {
            return Task.CompletedTask;
        }

        public string GenerateTestUrl(string domain, string queryParams)
        {
            return "about:blank";
        }

        public Task<object> GetDebugInfo()
        {
            // If required return an ExpandoObject
            return Task.FromResult((object)null);
        }

        public int GetItemCount(ItemPath itemPath)
        {
            return 0;
        }

        public T GetPropertyValueFromControl<T>(ItemPath itemPath)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, ControlRecordValue>> LoadObjectModelAsync()
        {
            return Task.FromResult(new Dictionary<string, ControlRecordValue>());
        }

        public Task<bool> SelectControlAsync(ItemPath itemPath)
        {
            return Task.FromResult(true);
        }

        public Task<bool> SetPropertyAsync(ItemPath itemPath, FormulaValue value)
        {
            return Task.FromResult(true);
        }

        public Task<bool> TestEngineReady()
        {
            return Task.FromResult(true);
        }
    }
}
