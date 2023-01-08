using System;
using System.Collections.Generic;
using System.Linq;
using ScriptMaker.Entry.Block.Contexts.Dialog;
using ScriptMaker.Program.Data;

namespace ScriptMakerCoreBlocks.Contexts
{
    public class RunCommandContextEditDialog : ContextEditDialog
    {
        protected override void Initialize() {
            if (Context.Value != "RunCommandContext") throw new ArgumentException("Given context is not RunCommandContext");
            AddDropdownMenu("Command type", new List<(string, string)> {("Server side", "Server"), ("Client side", "Client")}, x => Context.Set("Side", x), Context["Side"].String());
            Next();
            AddSingleLineInputField("Command", x => Context.Set("Command", x), Context["Command"].String());
        }
    }
}