using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerLabledVariableUnplannedException : AssemblerException {
        public AssemblerLabledVariableUnplannedException(string message, Exception exception) : base(message, exception) { }
    }
}
