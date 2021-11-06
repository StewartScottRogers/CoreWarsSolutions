using System;
using System.Text;

using CoreWars.Engine.Extentions;

namespace CoreWars.Engine {
    internal class MemoryCore {
        private const int DefaultMemoryCellsChunkSize = 20;
        private readonly short[] MemoryCells;

        private int MemoryCellsChunkCount = 1;
        private int MemoryCellsChunkSize = DefaultMemoryCellsChunkSize;

        public MemoryCore(int memoryCellsSize = DefaultMemoryCellsChunkSize * 8) {
            MemoryCellsChunkSize = DefaultMemoryCellsChunkSize / sizeof(short);
            if (memoryCellsSize < MemoryCellsChunkSize)
                memoryCellsSize = MemoryCellsChunkSize;

            MemoryCellsChunkCount = (int)(memoryCellsSize / MemoryCellsChunkSize);
            MemoryCells = new short[MemoryCellsChunkSize * MemoryCellsChunkCount];
        }

        public (short MemoryCellPointer, short MemoryCell) AccessMemoryCell(short memoryCellPointer) {
            short memoryCell = MemoryCells[GetSafeMemoryCellPointer(memoryCellPointer)];
            return (memoryCellPointer, memoryCell);
        }

        public void AccessMemoryCell(short memoryCellPointer, short memoryCell)
            => MemoryCells[GetSafeMemoryCellPointer(memoryCellPointer)] = memoryCell;

        public short Length { get => (short)MemoryCells.Length; }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder();

            for (int memoryCellSpanPointer = 0; memoryCellSpanPointer < MemoryCellsChunkCount; memoryCellSpanPointer++) {
                var memoryCellSpan = new Span<short>(MemoryCells, (memoryCellSpanPointer * MemoryCellsChunkSize), MemoryCellsChunkSize);
                var memoryCellArray = memoryCellSpan.ToArray();
                string hexString = memoryCellArray.ToHexString();
                stringBuilder.AppendLine(hexString);
            }

            return stringBuilder.ToString();
        }

        private short GetSafeMemoryCellPointer(short memoryCellPointer) => (short)(memoryCellPointer % Length);
    }
}
