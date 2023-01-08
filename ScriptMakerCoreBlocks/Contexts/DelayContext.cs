using System.Collections.Generic;
using System.Linq;
using ScriptMaker.Entry.Block.Contexts.Dialog;
using ScriptMaker.Program.Data;
using UnityEngine.UI;

namespace ScriptMakerCoreBlocks.Contexts
{
    class DelayContextEditDialog : ContextEditDialog
    {
        private InputField timeIpf;
        protected override void Initialize()
        {
            Context.SetDefaultOf("Time", "0");
            AddDropdownMenu("Type", new List<(string, string)> { ("Arrow", "Arrow"), ("Time", "Time") }, x =>
            {
                Context.Set("Type", x);
                timeIpf.gameObject.SetActive(x == "Time");
            }, Context["Type"].String());
            Next();
            AddSingleLineInputField("Time", x => Context.Set("Time", x), Context["Time"].String(), transform: x =>
            {
                this.timeIpf = x;
                x.onValidateInput += floatValidator;
                x.gameObject.SetActive(Context["Type"].String() == "Time");
            });
        }
    }
}