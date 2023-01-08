using ScriptMaker.Entry.Block.Interface;
using ScriptMaker.Program.Data;
using UnityEngine;

namespace ScriptMakerCoreBlocks.Blocks
{
    public class ButtonBlock: MultipleSelectableBlock
    {
        protected override string Text => $"Button image: {Context["ButtonImage"].String()}";
        protected override Color Color => Color.yellow;
    }
}