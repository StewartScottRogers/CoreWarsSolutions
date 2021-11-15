using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class BaseException : ApplicationException {
        public BaseException(string message) : base(message) { }

        public BaseException(string message, Exception exception) : base(message, exception) { }
    }
}
