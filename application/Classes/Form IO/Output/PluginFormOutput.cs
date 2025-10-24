using plugin.Classes.Actions;
using plugin.Classes.Actions.OnInvokeTask;
using plugin.Classes.Actions.Window;
using System.Collections.Generic;

namespace pie.Classes.Form_IO.Output
{
    public class PluginFormOutput
    {
        public bool ApplyChanges { get; set; }
        public Dictionary<string, string> ControlKeyValues { get; set; }
        public List<OnWindowCloseAction> OnCloseActions { get; set; }
    }
}

