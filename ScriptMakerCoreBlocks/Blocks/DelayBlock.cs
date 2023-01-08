using ScriptMaker.Entry.Block;
using ScriptMaker.Entry.Block.Contexts;
using ScriptMaker.Program.Data;
using UnityEngine;

namespace ScriptMakerCoreBlocks.Blocks
{
    public class DelayBlock: BaseBlock
    {
        protected override string Text => $"Delay by {Context["Type"].String()}";
        protected override Color Color => Color.white;
    }
}