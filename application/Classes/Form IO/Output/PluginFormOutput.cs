using plugin.Classes.Actions;
using System.Collections.Generic;

namespace pie.Classes.Form_IO.Output
{
    public class PluginFormOutput
    {
        public bool ApplyChanges { get; set; }
        public Dictionary<string, string> ControlKeyValues { get; set; }
        public List<ExitAction> OnCloseActions { get; set; }
    }
}

