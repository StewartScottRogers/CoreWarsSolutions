using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterException : ApplicationException {
        public LinterException(string message) : base(message) { }
    }
}
