using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerLabledLineNumberUnplannedException : AssemblerException {
        public AssemblerLabledLineNumberUnplannedException(string message, Exception exception) : base(message, exception) { }
    }
}
