namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterOpcodeMissingParameterAException : LinterException {
        public LinterOpcodeMissingParameterAException((int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) codeLine) 
            : base($"Opcode missing {nameof(codeLine.ParameterA)} for the {nameof(codeLine.Command)} '{codeLine.Command}' on {nameof(codeLine.LineNumber)} '{codeLine.LineNumber}' of the source code.") { }
    }
}
