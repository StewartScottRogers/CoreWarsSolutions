using System;

using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerOpcodeExtentions {

        public static short ToOpcode(this string mnemonic)
            => mnemonic.ToOpcodeType().ToOpcode();

        public static OpcodeTypes ToOpcodeType(this short memoryCell) {
            switch (memoryCell) {
                case 0: return OpcodeTypes.dat;
                case 1: return OpcodeTypes.mov;
                case 2: return OpcodeTypes.add;
                case 3: return OpcodeTypes.sub;
                case 4: return OpcodeTypes.jmp;
                case 5: return OpcodeTypes.djz;
                case 6: return OpcodeTypes.cmp;
                default:
                    throw new AssemblerOpcodeFormatExceptionException("");
            }
        }


        private static short ToOpcode(this OpcodeTypes opcodeType) {
            switch (opcodeType) {
                case OpcodeTypes.dat: return 0;
                case OpcodeTypes.mov: return 1;
                case OpcodeTypes.add: return 2;
                case OpcodeTypes.sub: return 3;
                case OpcodeTypes.jmp: return 4;
                case OpcodeTypes.djz: return 5;
                case OpcodeTypes.cmp: return 6;

                default:
                    throw new AssemblerOpcodeTypeUnknownException(opcodeType);
            }
        }

        private static OpcodeTypes ToOpcodeType(this string mnemonic) {
            try {
                return (OpcodeTypes)Enum.Parse(typeof(OpcodeTypes), mnemonic);
            } catch (FormatException) {
                throw new AssemblerOpcodeFormatExceptionException(mnemonic);
            }
        }
    }
}
