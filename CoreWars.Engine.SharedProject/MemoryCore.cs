using System;
using System.Text;

using CoreWars.Engine.Extentions;

namespace CoreWars.Engine {
    internal class MemoryCore {
        private const short DefaultMemoryCellsChunkSize = 20;
        private readonly short[] MemoryCells;

        private short MemoryCellsChunkCount = 1;
        private short MemoryCellsChunkSize = DefaultMemoryCellsChunkSize;

        public MemoryCore(int memoryCellsSize = DefaultMemoryCellsChunkSize * 8) {
            MemoryCellsChunkSize = DefaultMemoryCellsChunkSize / sizeof(short);
            if (memoryCellsSize < MemoryCellsChunkSize)
                memoryCellsSize = MemoryCellsChunkSize;

            MemoryCellsChunkCount = (short)(memoryCellsSize / MemoryCellsChunkSize);
            MemoryCells = new short[MemoryCellsChunkSize * MemoryCellsChunkCount];
        }

        public (short MemoryCellPointer, short MemoryCell) AccessMemoryCell(short memoryCellPointer) {
            short memoryCell = MemoryCells[GetSafeMemoryCellPointer(memoryCellPointer)];
            return (memoryCellPointer, memoryCell);
        }

        public void AccessMemoryCell(short memoryCellPointer, short memoryCell)
            => MemoryCells[GetSafeMemoryCellPointer(memoryCellPointer)] = memoryCell;

        public short Length { get => (short)MemoryCells.Length; }

        public override String ToString()
            => (Cells: MemoryCells, CellsChunkCount: MemoryCellsChunkCount, CellsChunkSize: MemoryCellsChunkSize).ToDisplay();


        private short GetSafeMemoryCellPointer(short memoryCellPointer) 
            => (short)(memoryCellPointer % Length);
    }
}
