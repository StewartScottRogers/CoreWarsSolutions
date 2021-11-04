using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class AddressingModeAttribute : SymbolAttribute {
        public AddressingModeAttribute(Boolean symbolEnabled, String symbol) : base(symbolEnabled, symbol) { }

        public AddressingModeAttribute(Boolean symbolEnabled, String symbol, String description) : base(symbolEnabled, symbol, description) { }

        public AddressingModeAttribute(Boolean symbolEnabled, String symbol, String description, String example) : base(symbolEnabled, symbol, description, example) { }
    }
}
