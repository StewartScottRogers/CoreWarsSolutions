namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterDirectiveMissingParameterAException : LinterException {
        public LinterDirectiveMissingParameterAException((short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) codeLine) 
            : base($"Directive missing {nameof(codeLine.ParameterA)} for the {nameof(codeLine.Command)} '{codeLine.Command}' on {nameof(codeLine.LineNumber)} '{codeLine.LineNumber}' of the source code.") { }
    }
}
