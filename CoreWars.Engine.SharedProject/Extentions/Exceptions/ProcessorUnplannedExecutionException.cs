using System;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions.Exceptions {
    public class ProcessorUnplannedExecutionException : ProcessorException {
        public ProcessorUnplannedExecutionException(OpcodeTypes opcodeType, short memoryCellPointer, Exception exception) 
            : base($"Unplanned Execution Exception, {nameof(opcodeType)}: {opcodeType}, {nameof(memoryCellPointer)}: {memoryCellPointer}.", exception) { }
    }
}
