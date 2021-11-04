using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal sealed class OpcodeAttribute : SymbolAttribute {
        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic) : base(mnemonicEnabled, mnemonic) { }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String description) : base(mnemonicEnabled, mnemonic, description) { }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String description, String example) : base(mnemonicEnabled, mnemonic, description, example) { }
    }
}
