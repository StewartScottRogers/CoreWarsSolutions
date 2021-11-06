using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerUnknownOpcodeTypeException : AssemblerException {
        public AssemblerUnknownOpcodeTypeException(OpcodeTypes opcodeType)
            : base($"Unknown Opcode '{opcodeType}'.") { }
    }
}
