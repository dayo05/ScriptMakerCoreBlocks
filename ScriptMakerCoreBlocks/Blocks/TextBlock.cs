using ScriptMaker.Entry.Block;
using ScriptMaker.Program.Data;
using UnityEngine;

namespace ScriptMakerCoreBlocks.Blocks
{
    public class TextBlock: BaseBlock
    {
        protected override string Text => Context["Text"].String();
        protected override Color Color => Color.cyan;
    }
}