using System;
using System.Linq;
using ScriptMaker.Entry.Block.Contexts.Dialog;
using ScriptMaker.Program.Data;

namespace ScriptMakerCoreBlocks.Contexts
{
    public class TextEditDialog: ContextEditDialog
    {
        protected override void Initialize()
        {
            if (Context.Value != "TextContext") throw new ArgumentException("Given context is not TextContext");

            AddText("t1", "Text X");
            AddSingleLineInputField("Bxipf", x => Context.Set("TextX", x), Context["TextX"].String(), xBias: 150,
                width: 200, transform: x => x.onValidateInput += floatValidator);
            Next();
            AddText("t1", "Text Y");
            AddSingleLineInputField("Bxipf", x => Context.Set("TextY", x), Context["TextY"].String(), xBias: 150,
                width: 200, transform: x => x.onValidateInput += floatValidator);
            Next();
            AddText("t1", "Text Scale");
            AddSingleLineInputField("Bxipf", x => Context.Set("TextScale", x), Context["TextScale"].String(), xBias: 150,
                width: 200, transform: x => x.onValidateInput += floatValidator);
            Next();
            AddText("t1", "Text Font");
            AddSingleLineInputField("Bxipf", x => Context.Set("TextFont", x), Context["TextFont"].String(), xBias: 150, width: 200);
            Next();
            AddText("t1", "Text Color");
            AddSingleLineInputField("Bxipf", x => Context.Set("TextColor", x), Context.SetDefaultOf("TextColor", "ffffff").String(), xBias: 150, width: 200);
            Next();
            AddInputField("Data", x => Context.Set("Text", x), Context["Text"].String(), height: 250);
        }
    }
}