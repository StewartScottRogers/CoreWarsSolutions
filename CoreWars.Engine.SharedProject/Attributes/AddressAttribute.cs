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

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, Boolean parameterRequiredA, Boolean parameterRequiredB, String standard) : base(mnemonicEnabled, mnemonic, parameterRequiredA, parameterRequiredB, standard) {
        }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description) {
        }

        public AddressAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description, String example) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description, example) {
        }
    }
}
