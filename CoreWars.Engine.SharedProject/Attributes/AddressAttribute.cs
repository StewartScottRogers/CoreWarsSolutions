using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class AddressAttribute : SymbolAttribute {
        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String standard) : base(mnemonicEnabled, mnemonic, standard) {
        }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description) : base(mnemonicEnabled, mnemonic, standard, description) {
        }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description, String example) : base(mnemonicEnabled, mnemonic, standard, description, example) {
        }
    }
}
