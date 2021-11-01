using System;

namespace CoreWars.Engine.Attributes {
    internal class AddressingModeAttribute : Attribute {

        public string Symbol { get; private set; }

        public string Description { get; private set; }

        public AddressingModeAttribute(string symbol) {
            Symbol = symbol;
            Description = string.Empty;
        }

        public AddressingModeAttribute(string symbol, string description) {
            Symbol = symbol;
            Description = description;
        }

        public override String ToString() => $"{Symbol}, '{Description}'.";

    }
}
