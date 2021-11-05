using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal sealed class OpcodeAttribute : SymbolAttribute {
        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard) : base(mnemonicEnabled, mnemonic, standard) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description) : base(mnemonicEnabled, mnemonic, standard, description) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description, String example) : base(mnemonicEnabled, mnemonic, standard, description, example) {
        }
    }
}
