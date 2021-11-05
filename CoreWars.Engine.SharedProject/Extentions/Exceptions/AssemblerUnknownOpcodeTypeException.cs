using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerUnknownOpcodeTypeException : AssemblerException {
        public AssemblerUnknownOpcodeTypeException((int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) codeLine)
            : base($"Unknown {nameof(codeLine.Command)} '{codeLine.Command}' on {nameof(codeLine.LineNumber)} '{codeLine.LineNumber}' of the source code.") { }
    }
}
