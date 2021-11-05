using System;

using CoreWars.Engine.Attributes.Library;

namespace CoreWars.Engine.Attributes {
    internal class DirectiveAttribute : SymbolAttribute {
        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String standard) : base(mnemonicEnabled, mnemonic, standard) {
        }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description) : base(mnemonicEnabled, mnemonic, standard, description) {
        }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description, String example) : base(mnemonicEnabled, mnemonic, standard, description, example) {
        }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, Boolean parameterRequiredA, Boolean parameterRequiredB, String standard) : base(mnemonicEnabled, mnemonic, parameterRequiredA, parameterRequiredB, standard) {
        }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description) {
        }

        public DirectiveAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description, String example) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description, example) {
        }
    }
}
