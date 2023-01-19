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
        private InputField keyIpf;
        protected override void Initialize()
        {
            // Compact for ~0.7
            if (Context["Type"].String() == "Arrow")
                Context.Set("Type", "Key");
            
            Context.SetDefaultOf("Key", "^0");
            Context.SetDefaultOf("Time", "0");
            AddDropdownMenu("Type", new List<(string, string)> { ("Key", "Key"), ("Time", "Time") }, x =>
            {
                Context.Set("Type", x);
                timeIpf.gameObject.SetActive(x == "Time");
                keyIpf.gameObject.SetActive(x == "Key");
            }, Context["Type"].String());
            Next();
            AddSingleLineInputField("Key", x => Context.Set("Key", x), Context["Key"].String(), transform: x =>
            {
                keyIpf = x;
                x.gameObject.SetActive(Context["Type"].String() == "Key");
            });
            AddSingleLineInputField("Time", x => Context.Set("Time", x), Context["Time"].String(), transform: x =>
            {
                this.timeIpf = x;
                x.onValidateInput += floatValidator;
                x.gameObject.SetActive(Context["Type"].String() == "Time");
            });
        }
    }
}