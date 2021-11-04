using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal sealed class OpcodeAttribute : SymbolAttribute {
        public OpcodeAttribute(Boolean symbolEnabled, String symbol) : base(symbolEnabled, symbol) { }

        public OpcodeAttribute(Boolean symbolEnabled, String symbol, String description) : base(symbolEnabled, symbol, description) { }

        public OpcodeAttribute(Boolean symbolEnabled, String symbol, String description, String example) : base(symbolEnabled, symbol, description, example) { }
    }
}
