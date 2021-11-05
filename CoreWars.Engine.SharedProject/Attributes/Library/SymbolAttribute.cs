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
        /// 
        /// </summary>
        public bool ParameterRequiredA { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ParameterRequiredB { get; private set; }

        /// <summary>
        ///  Draft Standard
        /// </summary>
        public string Standard { get; private set; }

        /// <summary>
        /// Description is provides in documentation to the end user.
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Example is provides in documentation to the end user.
        /// </summary>
        public string Example { get; private set; }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string standard) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = false;
            ParameterRequiredB = false;
            Standard = standard.Trim().ToLower();   
            Description = string.Empty;
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string standard, string description) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = false;
            ParameterRequiredB = false;
            Standard = standard.Trim().ToLower();
            Description = description.Trim();
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string standard, string description, string example) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = false;
            ParameterRequiredB = false;
            Standard = standard.Trim().ToLower();
            Description = description.Trim();
            Example = example.Trim();
        }





        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, bool parameterRequiredA, bool parameterRequiredB, string standard) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = parameterRequiredA;
            ParameterRequiredB = parameterRequiredB;
            Standard = standard.Trim().ToLower();
            Description = string.Empty;
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string standard, bool parameterRequiredA, bool parameterRequiredB, string description) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = parameterRequiredA;
            ParameterRequiredB = parameterRequiredB;
            Standard = standard.Trim().ToLower();
            Description = description.Trim();
            Example = string.Empty;
        }

        public SymbolAttribute(bool mnemonicEnabled, string mnemonic, string standard, bool parameterRequiredA, bool parameterRequiredB, string description, string example) {
            MnemonicEnabled = mnemonicEnabled;
            Mnemonic = mnemonic.Trim().ToLower();
            ParameterRequiredA = parameterRequiredA;
            ParameterRequiredB = parameterRequiredB;
            Standard = standard.Trim().ToLower();
            Description = description.Trim();
            Example = example.Trim();
        }

        public override String ToString() => $"{Standard}: {MnemonicEnabled} {Mnemonic}, '{Description}', '{Example}'.";
    }
}
