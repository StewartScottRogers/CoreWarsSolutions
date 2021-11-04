using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class DirectiveAttribute : SymbolAttribute {
        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic) : base(mnemonicEnabled, mnemonic) { }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String description) : base(mnemonicEnabled, mnemonic, description) { }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String description, String example) : base(mnemonicEnabled, mnemonic, description, example) { }
    }
}
