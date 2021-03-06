using ScriptCs.Contracts;

namespace ScriptCs
{
    public interface IShebangLineProcessor : ILineProcessor
    {
    }

    public class ShebangLineProcessor : DirectiveLineProcessor, IShebangLineProcessor
    {
        protected override string DirectiveName => "!/usr/bin/env";

        protected override bool ProcessLine(IFileParser parser, FileParserContext context, string line) => true;
    }
}