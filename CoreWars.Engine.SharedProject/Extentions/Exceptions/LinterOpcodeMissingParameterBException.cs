namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterOpcodeMissingParameterBException : LinterException {
        public LinterOpcodeMissingParameterBException((short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) codeLine) 
            : base($"Opcode missing {nameof(codeLine.ParameterB)} for the {nameof(codeLine.Command)} '{codeLine.Command}' on {nameof(codeLine.LineNumber)} '{codeLine.LineNumber}' of the source code.") { }
    }
}
