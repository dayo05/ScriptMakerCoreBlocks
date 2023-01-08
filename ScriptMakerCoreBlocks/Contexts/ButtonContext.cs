using System;
using System.Linq;
using ScriptMaker.Entry.Block.Contexts.Dialog;
using ScriptMaker.Program.Data;
using UnityEngine.UI;

namespace ScriptMakerCoreBlocks.Contexts
{
    public class ButtonEditDialog : ContextEditDialog
    {
        private Toggle autoSize;
        private InputField bw, bh;
        private Text bwt, bht;
        protected override void Initialize()
        {
            if (Context.Value != "ButtonContext") throw new ArgumentException("Given context is not ButtonContext");

            AddText("t1", "Button X");
            AddSingleLineInputField("Bxipf", x => Context.Set("ButtonX", x), Context["ButtonX"].String(), xBias: 150,
                width: 200, transform: x => x.onValidateInput += floatValidator);
            Next();
            AddText("t2", "Button Y");
            AddSingleLineInputField("Byipf", x => Context.Set("ButtonY", x), Context["ButtonY"].String(), xBias: 150,
                width: 200, transform: x => x.onValidateInput += floatValidator);
            Next();
            AddText("t5", "Button Image");
            AddSingleLineInputField("Bimipf", x => Context.Set("ButtonImage", x), Context["ButtonImage"].String(), xBias: 150, width: 200);
            Next();
            AddCheckbox("AutoSize", "Auto Select Size", x =>
            {
                Context.Set("AutoSize", x.ToString());
                bw.gameObject.SetActive(!x);
                bwt.gameObject.SetActive(!x);
                bh.gameObject.SetActive(!x);
                bht.gameObject.SetActive(!x);
            }, Context.SetDefaultOf("AutoSize", false.ToString()).Bool(), transform: x => autoSize = x);
            Next();
            AddText("t3", "Button Width", transform: x =>
            {
                bwt = x;
                x.gameObject.SetActive(!autoSize.isOn);
            });
            AddSingleLineInputField("Bwipf", x => Context.Set("ButtonWidth", x), Context["ButtonWidth"].String(),
                xBias: 150, width: 200, transform: x =>
                {
                    x.onValidateInput += floatValidator;
                    x.gameObject.SetActive(!autoSize.isOn);
                    bw = x;
                });
            Next();
            AddText("t4", "Button Height", transform: x =>
            {
                bht = x;
                x.gameObject.SetActive(!autoSize.isOn);
            });
            AddSingleLineInputField("Bhipf", x => Context.Set("ButtonHeight", x), Context["ButtonHeight"].String(),
                xBias: 150, width: 200, transform: x =>
                {
                    x.onValidateInput += floatValidator;
                    x.gameObject.SetActive(!autoSize.isOn);
                    bh = x;
                });
            }
    }
}