using System;

namespace CoreWars.Engine.Attributes {
    internal class SpecialCommandAttribute : Attribute{
        public string Symbol { get; private set; }

        public string Description { get; private set; }

        public SpecialCommandAttribute(string symbol) {
            Symbol = symbol;
            Description = string.Empty;
        }

        public SpecialCommandAttribute(string symbol, string description) {
            Symbol = symbol;
            Description = description;
        }

        public override String ToString() => $"{Symbol}, '{Description}'.";
    }
}
