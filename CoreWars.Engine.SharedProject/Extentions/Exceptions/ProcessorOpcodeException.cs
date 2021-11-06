using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class ProcessorOpcodeException : ProcessorException {
        public OpcodeTypes OpcodeType { get; private set; }
        public ProcessorOpcodeException(OpcodeTypes opcodeType, string message) : base($"Opcode '{opcodeType}' {message}") {
            OpcodeType = opcodeType;
        }
    }
}
