using ScriptMaker.Entry.Block;
using ScriptMaker.Program.Data;
using UnityEngine;

namespace ScriptMakerCoreBlocks.Blocks
{
    public class RunCommandBlock: BaseBlock
    {
        protected override string Text => $"Execute as {Context["Side"].String()}: {Context["Command"].String()}";
        protected override Color Color => Color.white;
    }
}