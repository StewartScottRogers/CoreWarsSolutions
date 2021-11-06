using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerOpcodeTypeUnknownException : AssemblerException {
        public AssemblerOpcodeTypeUnknownException(OpcodeTypes opcodeType)
            : base($"Unknown Opcode '{opcodeType}'.") { }
    }
}
