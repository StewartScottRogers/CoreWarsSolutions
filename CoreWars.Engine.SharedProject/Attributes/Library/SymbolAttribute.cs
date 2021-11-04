using System;

namespace CoreWars.Engine.Attributes.Library {
    internal class SymbolAttribute : Attribute {

        /// <summary>
        /// If enabled the Symbol is available to the interpreter / compiler tool chain.
        /// </summary>
        public bool MnemonicEnabled { get; private set; }

        /// <summary>
        /// Symbol used by the interpreter / compiler for converting asm to binnary
        /// </summary>
        public string Mnemonic { get; private set; }

        /// <summary>
        /// Description is provides in documentation to the end user.
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Example is provides in documentation to the end user.
        /// </summary>
        public string Example { get; private set; }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            Description = string.Empty;
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string description) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            Description = description.Trim();
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string description, string example) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            Description = description.Trim();
            Example = example.Trim();
        }

        public override String ToString() => $"{MnemonicEnabled} {Mnemonic}, '{Description}', '{Example}'.";
    }
}
