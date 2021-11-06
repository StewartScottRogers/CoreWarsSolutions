using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class ProcessorException : ApplicationException {
        public ProcessorException(string message) : base(message) { }

        public ProcessorException(string message, Exception exception) : base(message, exception) { }
    }
}
