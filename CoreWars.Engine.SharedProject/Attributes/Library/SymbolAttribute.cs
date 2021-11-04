using System;

namespace CoreWars.Engine.Attributes.Library {
    internal class SymbolAttribute : Attribute {
        public bool SymbolEnabled { get; private set; }

        public string Symbol { get; private set; }

        public string Description { get; private set; }

        public string Example { get; private set; }

        public SymbolAttribute(bool symbolEnabled, string symbol) {
            SymbolEnabled = symbolEnabled;
            Symbol = symbol.Trim().ToLower();
            Description = string.Empty;
            Example = string.Empty;
        }

        public SymbolAttribute(bool symbolEnabled, string symbol, string description) {
            SymbolEnabled = symbolEnabled;
            Symbol = symbol.Trim().ToLower();
            Description = description;
            Example = string.Empty;
        }

        public SymbolAttribute(bool symbolEnabled, string symbol, string description, string example) {
            SymbolEnabled = symbolEnabled;
            Symbol = symbol.Trim().ToLower();
            Description = description;
            Example = example;
        }

        public override String ToString() => $"{SymbolEnabled} {Symbol}, '{Description}', '{Example}'.";
    }
}
