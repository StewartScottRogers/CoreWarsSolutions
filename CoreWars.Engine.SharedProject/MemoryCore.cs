using System;
using System.Text;

using CoreWars.Engine.Extentions;

namespace CoreWars.Engine {
    internal class MemoryCore {
        private readonly int BufferChunkSize = 80;
        private readonly int BufferChunkCount;
        private readonly byte[] Buffer;

        public MemoryCore(uint eightyByteBufferChunkCount = 1) {
            BufferChunkCount = (Int32)eightyByteBufferChunkCount;
            Buffer = new byte[BufferChunkSize * BufferChunkCount];
        }

        public byte Read(int memoryIndex) 
            => Buffer[SGetafeMemoryIndex(memoryIndex)];

        public void Write(int memoryIndex, byte memoryByte) =>
            Buffer[SGetafeMemoryIndex(memoryIndex)] = memoryByte;
        
        public int Size { get => Buffer.Length; }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder();

            for (int bufferSpanIndex = 0; bufferSpanIndex < BufferChunkCount; bufferSpanIndex++) {
                var bufferSpan = new Span<byte>(Buffer, (bufferSpanIndex * BufferChunkSize), BufferChunkSize);
                string hexString = bufferSpan.ToArray().ToHexString();
                stringBuilder.AppendLine(hexString);
            }

            return stringBuilder.ToString();
        }

        private int SGetafeMemoryIndex(int memoryIndex) => (memoryIndex % Buffer.Length);
    }
}
