using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerOpcodeExtentions {
        public static short ToOpcode(OpcodeTypes opcodeType) {
            switch (opcodeType) {
                case OpcodeTypes.DAT: return 0;
                case OpcodeTypes.MOV: return 1;
                case OpcodeTypes.ADD: return 2;
                case OpcodeTypes.SUB: return 3;
                case OpcodeTypes.JMP: return 4;
                case OpcodeTypes.DJZ: return 5;
                case OpcodeTypes.CMP: return 6;

                default:
                    throw new AssemblerUnknownOpcodeTypeException(opcodeType);
            }
        }
    }
}
