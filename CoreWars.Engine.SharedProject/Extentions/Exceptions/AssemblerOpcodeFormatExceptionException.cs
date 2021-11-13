using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerOpcodeFormatExceptionException : AssemblerException {
        public AssemblerOpcodeFormatExceptionException(string mnemonic)
            : base($"Unformatable Mnemonic '{mnemonic}'.") { }
    }
}
