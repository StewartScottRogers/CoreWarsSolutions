using System;

namespace CoreWars.Engine.Attributes {
    internal class SpecialCommandAttribute : Attribute{
        public string Symbol { get; private set; }

        public string Description { get; private set; }

        public string Example { get; private set; }

        public SpecialCommandAttribute(string symbol) {
            Symbol = symbol;
            Description = string.Empty;
            Example = string.Empty;
        }

        public SpecialCommandAttribute(string symbol, string description) {
            Symbol = symbol;
            Description = description;
            Example = string.Empty;
        }

        public SpecialCommandAttribute(string symbol, string description, string example) {
            Symbol = symbol;
            Description = description;
            Example = example;
        }

        public override String ToString() => $"{Symbol}, '{Description}', '{Example}'.";
    }
}
