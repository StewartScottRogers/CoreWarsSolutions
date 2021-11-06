using System;

namespace CoreWars.Engine.Attributes {
    internal sealed class OpcodeAttribute : SymbolAttribute {
        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard) : base(mnemonicEnabled, mnemonic, standard) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description) : base(mnemonicEnabled, mnemonic, standard, description) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, String description, String example) : base(mnemonicEnabled, mnemonic, standard, description, example) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, Boolean parameterRequiredA, Boolean parameterRequiredB, String standard) : base(mnemonicEnabled, mnemonic, parameterRequiredA, parameterRequiredB, standard) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description) {
        }

        public OpcodeAttribute(Boolean mnemonicEnabled, String mnemonic, String standard, Boolean parameterRequiredA, Boolean parameterRequiredB, String description, String example) : base(mnemonicEnabled, mnemonic, standard, parameterRequiredA, parameterRequiredB, description, example) {
        }
    }
}
