using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class LinterException : BaseException {
        public LinterException(string message) : base(message) { }
    }
}
