using System;

using CoreWars.Engine.Attributes;
using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal class ProcessorCore {
        private MemoryCore MemoryCore { get; set; }
        public short MemoryCellPointer { get; private set; }
        public short RegisterInstruction { get; private set; }
        public short RegisterA { get; private set; }
        public short RegisterB { get; private set; }

        public ProcessorCore(MemoryCore memoryCore, short memoryCellPointer) {
            MemoryCore = memoryCore;
            MemoryCellPointer = memoryCellPointer;
        }

        public void LoadInstruction() {
            (short MemoryCellPointer, short MemoryCell) accessedOpcode = MemoryCore.AccessMemoryCell(MemoryCellPointer);
            IncrementMemoryCellPointer();
            OpcodeTypes opcodeType = accessedOpcode.MemoryCell.ToOpcodeType();
            SymbolAttribute symbolAttribute = DecodeInstruction(opcodeType);
            ExecuteInstruction(opcodeType, accessedOpcode.MemoryCellPointer);
        }

        private SymbolAttribute DecodeInstruction(OpcodeTypes opcodeType) {
            SymbolAttribute symbolAttribute = opcodeType.GetSymbol();

            if (symbolAttribute.ParameterRequiredA) {
                RegisterA = MemoryCore.AccessMemoryCell(MemoryCellPointer).MemoryCell;
                IncrementMemoryCellPointer();
            }

            if (symbolAttribute.ParameterRequiredB) {
                RegisterB = MemoryCore.AccessMemoryCell(MemoryCellPointer).MemoryCell;
                IncrementMemoryCellPointer();
            }

            return symbolAttribute;
        }

        private void ExecuteInstruction(OpcodeTypes opcodeType, short memoryCellPointer) {
            try {
                switch (opcodeType) {
                    case OpcodeTypes.dat: throw new ProcessorOpcodeException(opcodeType, "Fault! Can Not Execute Data.");

                    case OpcodeTypes.mov: {
                            (short MemoryCellPointer, short MemoryCell) accessedRegisterA = MemoryCore.AccessMemoryCell(RegisterA);
                            (short MemoryCellPointer, short MemoryCell) accessedRegisterB = MemoryCore.AccessMemoryCell(RegisterB);
                            (short MemoryCellPointer, short MemoryCell) accessedData = MemoryCore.AccessMemoryCell(accessedRegisterA.MemoryCellPointer);
                            MemoryCore.AccessMemoryCell(accessedRegisterB.MemoryCellPointer, accessedData.MemoryCell);
                            return;
                        }

                    default:
                        throw new ProcessorOpcodeException(opcodeType, "Fault! Can Not Map to an enabled Opcode.");
                }
            }catch(Exception exception) {
                throw new ProcessorUnplannedExecutionException(opcodeType, memoryCellPointer, exception);   
            }
        }

        private void IncrementMemoryCellPointer(short increment = 1) {
            MemoryCellPointer++;
            if (MemoryCellPointer >= MemoryCore.Length)
                MemoryCellPointer = 0;
        }
    }
}
