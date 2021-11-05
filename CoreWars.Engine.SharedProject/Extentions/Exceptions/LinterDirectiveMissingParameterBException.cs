namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterDirectiveMissingParameterBException : LinterException {
        public LinterDirectiveMissingParameterBException((int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) codeLine) 
            : base($"Directive missing {nameof(codeLine.ParameterB)} for the {nameof(codeLine.Command)} '{codeLine.Command}' on {nameof(codeLine.LineNumber)} '{codeLine.LineNumber}' of the source code.") { }
    }
}
