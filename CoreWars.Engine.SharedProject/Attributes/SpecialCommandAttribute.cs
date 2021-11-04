using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class SpecialCommandAttribute : SymbolAttribute {
        public SpecialCommandAttribute(Boolean symbolEnabled, String symbol) : base(symbolEnabled, symbol) { }

        public SpecialCommandAttribute(Boolean symbolEnabled, String symbol, String description) : base(symbolEnabled, symbol, description) { }

        public SpecialCommandAttribute(Boolean symbolEnabled, String symbol, String description, String example) : base(symbolEnabled, symbol, description, example) { }
    }
}
