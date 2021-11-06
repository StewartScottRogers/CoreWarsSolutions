using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class ProcessorUnplannedException : ProcessorException {
        public ProcessorUnplannedException(OpcodeTypes opcodeType, short memoryCellPointer, Exception exception) 
            : base($"Unplanned Exception, {nameof(opcodeType)}: {opcodeType}, {nameof(memoryCellPointer)}: {memoryCellPointer}.", exception) { }
    }
}
