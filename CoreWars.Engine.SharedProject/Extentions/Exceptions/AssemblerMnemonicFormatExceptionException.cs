using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerMnemonicFormatExceptionException : AssemblerException {
        public AssemblerMnemonicFormatExceptionException(string mnemonic)
            : base($"Unformatable Mnemonic '{mnemonic}'.") { }
    }
}
