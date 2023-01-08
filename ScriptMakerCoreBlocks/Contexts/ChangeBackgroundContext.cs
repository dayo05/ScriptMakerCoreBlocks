using System;
using System.Collections.Generic;
using System.Linq;
using ScriptMaker.Entry.Block.Contexts.Dialog;
using ScriptMaker.Program.Data;
using UnityEngine;

namespace ScriptMakerCoreBlocks.Contexts
{
    public class ChangeBackgroundContextEditDialog: ContextEditDialog
    {
        private GameObject? infoipf = null;
        protected override void Initialize()
        {
            if (Context.Value != "ChangeBackgroundContext")
                throw new ArgumentException("Given context is not ChangeBackgroundContext");
            AddDropdownMenu("TypeDropdown", new List<(string, string)> { ("Push", "Push"), ("Reset", "Reset"), ("Pop", "Pop") },
                x =>
                {
                    Context.Set("Type", x);
                    if(infoipf is not null)
                        infoipf.SetActive(x != "Pop");
                },
                Context["Type"].String());
            Next();
            AddInputField("Image", x => { Context.Set("Images", x); }, Context["Images"].String(), transform: x =>
            {
                infoipf = x.gameObject;
                infoipf.SetActive(Context["Type"].String() != "Pop");
            });
        }
    }
}