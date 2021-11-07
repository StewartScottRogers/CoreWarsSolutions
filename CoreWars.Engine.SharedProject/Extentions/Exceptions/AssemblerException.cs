﻿using System;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class AssemblerException : ApplicationException {
        public AssemblerException(string message) : base(message) { }

        public AssemblerException(string message, Exception exception) : base(message, exception) { }
    }
}
