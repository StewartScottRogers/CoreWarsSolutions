using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class AddressAttribute : SymbolAttribute {
        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic) : base(mnemonicEnabled, mnemonic) { }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String description) : base(mnemonicEnabled, mnemonic, description) { }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String description, String example) : base(mnemonicEnabled, mnemonic, description, example) { }
    }
}
