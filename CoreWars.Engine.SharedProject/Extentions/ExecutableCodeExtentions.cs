using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWars.Engine.Extentions {
    internal static class ExecutableCodeExtentions {
        public static string ToDisplay(this IEnumerable<Int16> executable) {
            short[] cells = executable.ToArray();
            return (Cells: cells, CellsChunkCount: (short)1, CellsChunkSize: (short)cells.Length).ToDisplay();
        }

        public static string ToDisplay(this (short[] Cells, short CellsChunkCount, short CellsChunkSize) cellMap) {
            StringBuilder stringBuilder = new StringBuilder();

            for (int memoryCellSpanPointer = 0; memoryCellSpanPointer < cellMap.CellsChunkCount; memoryCellSpanPointer++) {
                var memoryCellSpan = new Span<short>(cellMap.Cells, (memoryCellSpanPointer * cellMap.CellsChunkSize), cellMap.CellsChunkSize);
                var memoryCellArray = memoryCellSpan.ToArray();
                string hexString = memoryCellArray.ToHexString();
                stringBuilder.AppendLine(hexString);
            }

            return stringBuilder.ToString();
        }
    }
}
