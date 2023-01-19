using ScriptMaker.Entry.Block;
using ScriptMaker.Program.Data;
using ScriptMaker.Program.Mod;
using ScriptMakerCoreBlocks.Blocks;
using ScriptMakerCoreBlocks.Contexts;

namespace ScriptMakerCoreBlocks
{
    [Mod("MakerCore")]
    public class ScriptMakerCoreBlocks
    {
        public ScriptMakerCoreBlocks()
        {
            BlockHandler.RegisterBlock(typeof(TextBlock), new Option("Context", "TextContext")
                .Append("Text", "")
                .Append("TextX", 0.0)
                .Append("TextY", 0.0)
                .Append("TextScale", 1.0)
                .Append("TextFont", "")
                .Append("TextColor", "ffffff"), typeof(TextEditDialog), "Text");
            BlockHandler.RegisterBlock(typeof(DelayBlock), new Option("Context", "DelayContext")
                .Append("Type", "Key")
                .Append("Time", "0")
                .Append("Key", "^0"), typeof(DelayContextEditDialog), "Delay");
            BlockHandler.RegisterBlock(typeof(ButtonBlock), new Option("Context", "ButtonContext")
            .Append("ButtonX", 0.0)
            .Append("ButtonY", 0.0)
            .Append("ButtonWidth", 100.0)
            .Append("ButtonHeight", 100.0)
            .Append("ButtonImage", ""), typeof(ButtonEditDialog), "Button");
            BlockHandler.RegisterBlock(typeof(RunCommandBlock), new Option("Context", "RunCommandContext")
                .Append("Command", "")
                .Append("Side", "Client"), typeof(RunCommandContextEditDialog), "Run Command");
            BlockHandler.RegisterBlock(typeof(ChangeBackgroundBlock), new Option("Context", "ChangeBackgroundContext")
                .Append("Images", "")
                .Append("Type", "Push"), typeof(ChangeBackgroundContextEditDialog), "Change background");
        }
    }
}