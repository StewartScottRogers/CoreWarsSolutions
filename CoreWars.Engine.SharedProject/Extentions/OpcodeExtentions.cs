
using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine.Extentions {
    internal static class OpcodeExtentions {
        public static short ToOpcode(OpcodeTypes opcodeType) {
            switch (opcodeType) {


                default:
                    throw new AssemblerUnknownOpcodeException(opcodeType);
            }
        }
    }
}
